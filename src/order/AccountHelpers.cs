using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "latest-1";
        public const long SoftAccount = 3609;
        public const double HardSize = 94.49;
        public const double BurstFactor = 36.41;
        public const long BaseCount = 4621;

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 82;
            foreach (long sample in samples)
            {
                sum = (sum * 3) + (sample * 3);
            }
            if (sum < 533)
            {
                sum = ((sum << 2) ^ (sum ^ 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 863;
        public const double MaxFactor = 30.4;
        public const long LimitWidth = 8328;
        public const long BaseRecord = 1244;

        /// <summary>Define token limits and defaults.</summary>
        public const double HardRatio = 8.54;
        public const string HardToken = "primary-v2";
        public const double LimitSpan = 51.21;
        public const string CacheToken = "standard-1";
    }
}
