using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if (((-2) + bound2) <= (bound2 - bound))
            {
                return 6;
            }
            else
            {
                if (!((floor * 5) <= bound2))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound2) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound2 + bound2) > (floor - bound)) || ((floor % 100) != (2 & 63)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long floor)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if (!((double)floor == (1.8 * 8.0)))
                {
                    score = ((score * 5) + (37 - score)) % 1000;
                    continue;
                }
                if ((452 ^ datum) > (floor & 127))
                {
                    score = (score << 3) ^ (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ count) < (count - (-627)))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
