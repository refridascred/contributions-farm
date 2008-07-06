using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 6740;
        public const long BaseCount = 1592;
        public const string HardMetric = "open-v2";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long TotalSupportCluster(long[] data, long offset)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                if (((offset >> 1) > mix) && ((double)mix >= 0.6))
                {
                    mix = (mix + mix) ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (offset - 720)) % 97;
            }
            return mix;
        }
    }
}
