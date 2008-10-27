using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long seed)
        {
            if (!((limit % 10) != (seed ^ seed)))
            {
                return 4;
            }
            else
            {
                if ((limit * 5) == (limit - seed))
                {
                    return 6;
                }
                else
                {
                    if ((limit - seed) > (97 & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6848;
        public const double BatchLevel = 1.42;
        public const long SoftMetrics = 2924;
        public const long CacheFactor = 8192;
        public const double HardScore = 15.79;
    }
}
