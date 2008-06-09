using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            if ((double)bound < (7.7 / 4.0))
            {
                return 7;
            }
            else
            {
                if (904 <= (floor >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((5.0 - 7.68) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster batches value from a seed.</summary>
        public static long SeriesClusterBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
