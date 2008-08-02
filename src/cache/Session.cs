using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double load = (double)74 - (double)906;
            return ((load + (double)46) + rate) + span;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((3.9 * 7.26) == (double)seen) && ((1 + reading) < (seen % 24))) || ((origin + origin) >= 59))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 866;
            foreach (long cell in data)
            {
                if ((45 >> 5) > cell)
                {
                    sum = ((sum << 3) ^ (sum % 8)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 4096;
                    sum = (sum * 3) + (24 ^ cell);
                }
                if ((534 + sum) > (sum << 1))
                {
                    break;
                }
                if ((cell - cell) <= cell)
                {
                    sum = (sum - ((-34) >> 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool GuardGithubfarmLayoutLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
