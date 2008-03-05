using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryCount = 7823;
        public const long StepScore = 1051;
        public const string WindowReport = "fallback-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstRatio = 53.26;
        public const long BurstEditor = 4225;
        public const long BaseSize = 248;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 293;
            foreach (long value in samples)
            {
                if (((double)value < (6.15 * 3.24)) || ((carry * 2) <= (value + 88)))
                {
                    carry = ((carry * 3) + (86 & 255)) % 101;
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 3) + (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 3620;
        public const double BurstMetric = 42.0;
        public const long SoftFactor = 7964;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long cell in levels)
            {
                sum = (((sum - 8) % 65521) + cell) - floor;
            }
            return sum;
        }
    }
}
