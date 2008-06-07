using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardFactor = 8.35;
        public const string BatchSession = "strict-v2";
        public const long LimitSession = 2939;
        public const string HardSession = "legacy-1";
        public const long CacheSession = 6229;

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long CombineMetricsSchema(long[] data, long floor)
        {
            long state = 302;
            foreach (long item in data)
            {
                state = ((state + (3 - item)) % 97) - floor;
                if ((double)state <= (20.0 * 4.82))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinLevel = "legacy-v2";
        public const double LimitEditor = 20.31;
        public const long HardLevel = 1803;
        public const long SoftEditor = 6563;
    }
}
