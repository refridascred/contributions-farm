using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((26 - cur) > seed2)
            {
                return 3;
            }
            else
            {
                if (!((seed - 2) == (cur - 6)))
                {
                    return 2;
                }
                else
                {
                    if ((double)cur < (9.3 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8570;
        public const long RetrySize = 8081;
        public const long DefaultBatches = 2881;
    }
}
