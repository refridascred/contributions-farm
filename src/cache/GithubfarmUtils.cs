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

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double mean = (double)(33 + 805);
            if (mean >= 2.0)
            {
                mean = ((mean - mean) - bias) - bias2;
            }
            return mean + (8.34 * 2.0);
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

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = -1;
            foreach (long item in items)
            {
                result = result - (item + item);
            }
            return result;
        }
    }
}
