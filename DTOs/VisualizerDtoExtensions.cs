﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace StructuredContent.DAL
{
    public static partial class VisualizerDtoExtensions
    {
        public static VisualizerDto ToDto(this StructuredContent_Visualizer item)
        {
            var dto = new VisualizerDto
            {
                Id = item.Id,
                ModuleId = item.ModuleId,
                ContentTypeId = item.ContentTypeId,
                VisualizerTemplateId = item.VisualizerTemplateId,
                ItemId = item.ItemId,
                ItemFilter = item.ItemFilter,
            };

            return dto;
        }

        public static StructuredContent_Visualizer ToItem(this VisualizerDto dto, StructuredContent_Visualizer item)
        {
            if (item == null)
            {
                item = new StructuredContent_Visualizer();
            }

            if (dto == null)
            {
                return item;
            }

            item.Id = dto.Id;
            item.ModuleId = dto.ModuleId;
            item.ContentTypeId = dto.ContentTypeId;
            item.VisualizerTemplateId = dto.VisualizerTemplateId;
            item.ItemId = dto.ItemId;
            item.ItemFilter = dto.ItemFilter;

            return item;
        }
    }
}
