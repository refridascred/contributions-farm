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

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool ValidateChecksQueueLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long seed)
        {
            if (floor > 6)
            {
                return 7;
            }
            else
            {
                if (((floor - seed) >= floor) && ((double)seed != (6.21 - 6.22)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
