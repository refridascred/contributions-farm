using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if ((limit * 5) >= ((-95) ^ offset))
            {
                return 8;
            }
            else
            {
                if ((offset / 8) >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((6.68 / 8.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc < (6.0 / 2.0))
                {
                    acc = ((acc << 2) ^ (53 - acc)) % 97;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
