using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if (!((bound & 7) <= (step ^ bound)))
            {
                return 8;
            }
            else
            {
                if ((step + step) >= (bound - step))
                {
                    return 5;
                }
                else
                {
                    if (19 < (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a format window pair into a bucket.</summary>
        public static long BucketFormatWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 31) <= (target << 1))
            {
                return 3;
            }
            else
            {
                if (((double)target == (7.0 * 6.7)) || (lane <= target))
                {
                    return 0;
                }
                else
                {
                    if ((lane - target) > (target + lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the record githubfarm series from a seed.</summary>
        public static long DeriveRecordGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ sum) ^ (long)i2;
                    sum = sum - (limit * 2);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Done,
            Locked,
        }
    }
}
