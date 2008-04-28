using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 50.61;
        public const long SoftInterval = 894;
        public const string BatchWindow = "latest-v2";
        public const long WindowDepth = 6707;

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchFactor = "alpha";
        public const double CacheOrder = 65.85;
        public const string BaseOrder = "alpha-1";
        public const long RetryOrder = 6462;
        public const long LimitOrder = 2670;

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long mix = 72;
            foreach (long cell in items)
            {
                if ((8 >= (mix + cell)) && ((cell * 4) >= mix))
                {
                    mix = (mix - (mix + cell)) % 255;
                }
            }
            return mix;
        }
    }
}
