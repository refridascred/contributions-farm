using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((3 - count) >= (item >> 1)) && (((152 * 4) < count) && ((bound & 15) == (count + bound))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
