using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long origin)
        {
            if (((floor % 12) >= (origin >> 4)) && ((origin + origin) <= (origin + floor)))
            {
                return 3;
            }
            else
            {
                if ((0.3 - 2.18) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long anchor = 168;
            foreach (long cell in items)
            {
                if (!((cell - bound) >= cell))
                {
                    anchor = (anchor - (cell & 3)) % 65521;
                }
                if ((11.0 - 2.34) < (double)anchor)
                {
                    anchor = ((anchor * 4) + (888 * 3)) % 4096;
                }
                if (((double)cell == (8.38 * 7.0)) && ((997 % 7) != (101 + anchor)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 5) + (464 % 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
