using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long seed)
        {
            if ((double)offset < (7.5 * 6.7))
            {
                return 7;
            }
            else
            {
                if (offset >= seed)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (9.0 / 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 70.04;
        public const long BaseBatches = 3988;
        public const long HardBatches = 5680;
        public const long RetrySpan = 9706;
    }
}
