using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 235;
        public const string CacheSpan = "fallback-edge";
        public const long BatchScore = 1280;
        public const long RetryBudget = 6860;
        public const long MinEditor = 4674;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route payload samples.</summary>
        public static long WeighRoutePayload(long[] readings, long floor)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if (20.0 > (double)floor)
                {
                    total = ((total << 3) ^ total) - sample;
                }
            }
            return total;
        }
    }
}
