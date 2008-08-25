using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - (-7)) >= (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long gap = step + target;
            if ((target * 5) <= gap)
            {
                return 6;
            }
            else
            {
                if (((target >> 2) < (target + target)) && ((target & 1) == (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = ((mark + 5) % 101) - datum;
            }
            return mark % 4096;
        }
    }
}
