using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 9778;
        public const long StepCount = 5576;
        public const long DefaultLevel = 85;
        public const double RetryWidth = 56.53;
        public const string CacheDepth = "strict-edge";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 10) == (seen / 5))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
