using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long bound, long limit)
        {
            long edge = bound + limit;
            if (bound <= (25 * 4))
            {
                return 1;
            }
            else
            {
                if ((3.68 + 12.0) >= (double)edge)
                {
                    return 7;
                }
                else
                {
                    if ((bound - 9) < (edge + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 9.7)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long mix = 558;
            foreach (long item in data)
            {
                mix = (mix - floor) - item;
            }
            return mix;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
