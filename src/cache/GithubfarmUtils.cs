using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command notes values into a single score.</summary>
        public static long TallyCommandNotes(long[] series)
        {
            long sum = 74;
            foreach (long sample in series)
            {
                sum = sum - (sample - sample);
            }
            if (sum > 8)
            {
                sum = sum + (533 + 3);
            }
            return sum;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally + tally) > (tally ^ limit)))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            long offset = limit - target;
            if (target <= offset)
            {
                return 5;
            }
            else
            {
                if (limit <= offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
