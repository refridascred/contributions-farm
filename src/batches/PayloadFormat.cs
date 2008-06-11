using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank tools checks input into a small class.</summary>
        public static long RankToolsChecks(long origin, long limit)
        {
            if (!((limit + 697) >= (limit % 97)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (20.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "cached-v2";
        public const long LimitLevel = 6942;
        public const long CacheEntry = 4864;
        public const double StepWidth = 78.42;

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "open";
        public const double HardFactor = 47.97;
        public const long RetryTimeout = 1359;
    }
}
