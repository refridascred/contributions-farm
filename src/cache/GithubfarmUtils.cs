using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 97.23;
        public const string StepMetric = "alpha";
        public const double HardSize = 0.76;
        public const string HardMetric = "alpha-edge";

        /// <summary>Compare every pair of channel entry readings.</summary>
        public static long CompareChannelEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long origin)
        {
            if ((10.0 / 6.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((3.43 * 9.39) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)5 > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)(-86) > (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally ^ tally) <= tally)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
