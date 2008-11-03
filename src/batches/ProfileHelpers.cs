using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long slot = bound + target;
            if (target > (bound & 127))
            {
                return 4;
            }
            else
            {
                if (!((double)bound >= (6.62 * 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (target <= (bound - slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 2) > (target & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultTimeout = 83.02;
        public const long CacheWindow = 1354;
        public const double CacheBudget = 20.69;
        public const long StepScore = 3441;

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample > (long)series.Length)
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
