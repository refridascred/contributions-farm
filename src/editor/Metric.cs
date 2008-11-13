using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context stats samples are out of range.</summary>
        public static long AuditContextStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen > (seen >> 2))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "alpha-1";
        public const double MaxFarm = 92.58;
        public const long LimitFarm = 959;
        public const string BurstRatio = "fallback-v2";
        public const long DefaultFarm = 2067;
    }
}
