using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally <= (tally << 1)) || (((1.2 - 8.23) <= (double)tally) || ((5.96 * 8.98) != (double)tally)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((518 - 3) != (bound + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (195 <= sample)
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Queued,
            Dropped,
            Closed,
        }
    }
}
