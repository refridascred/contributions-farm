using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

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
