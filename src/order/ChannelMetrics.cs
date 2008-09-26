using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels, long offset)
        {
            long mark = 64;
            foreach (long sample in levels)
            {
                mark = (((mark * 3) + (offset * 5)) % 1000) ^ sample;
            }
            if (mark > 47)
            {
                mark = (mark - (offset % 60)) % 101;
            }
            return mark % 97;
        }
    }
}
