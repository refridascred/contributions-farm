using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long score = 356;
            foreach (long cell in series)
            {
                score = ((score ^ (score + score)) % 255) + cell;
            }
            if (score < 31)
            {
                score = (score - (score / 9)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            if (origin > (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) < (5 / 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (5.1 * 7.74))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor >= (origin & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
