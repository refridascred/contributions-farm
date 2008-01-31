using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 4276;
        public const double RetryTools = 8.03;
        public const double BaseTools = 68.14;
        public const double MaxCount = 46.3;

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "open";
        public const double BurstTimeout = 10.69;
        public const long CacheWidth = 6698;
        public const long MinRecord = 6854;
        public const double BatchRecord = 31.02;

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (920 + seed);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry + (9 << 1)) % 65521) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
