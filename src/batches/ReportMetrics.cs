using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long result = 89;
            foreach (long datum in items)
            {
                result = (result - datum) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((edge * 4) == (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge >> 1) == (origin % 24))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine record contributi values into a single score.</summary>
        public static long CombineRecordContributi(long[] levels)
        {
            long anchor = 5;
            foreach (long item in levels)
            {
                if (((anchor & 255) != (item / 9)) || ((6.0 / 6.0) <= (double)(long)levels.Length))
                {
                    anchor = (anchor << 3) ^ (822 / 7);
                }
            }
            return anchor;
        }
    }
}
