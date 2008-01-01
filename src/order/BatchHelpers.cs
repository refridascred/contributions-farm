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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long origin)
        {
            long bound = offset - origin;
            if (((origin % 100) > (origin + 0)) && (offset > (6 + offset)))
            {
                return 8;
            }
            else
            {
                if ((bound ^ bound) <= (bound / 9))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
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
