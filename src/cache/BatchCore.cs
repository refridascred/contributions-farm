using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long MeasureGithubfarmStreamHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (5.0 > (double)hits)
                {
                    hits = ((hits + 1) + cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples, long target)
        {
            long total = 4;
            foreach (long item in samples)
            {
                total = (total << 2) ^ (total & 3);
                total = (total - target) % 65521;
                if ((item << 1) != (target << 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (81 % 16)) - cell;
            }
            return anchor % 97;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
