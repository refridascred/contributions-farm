using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count <= (8.0 / 9.0))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7482;
        public const long WindowBudget = 4725;
        public const string BatchGithubfarm = "open-v2";
        public const string SoftGithubfarm = "staging";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long floor)
        {
            if (((seed >> 5) != (seed - floor)) || ((floor % 3) >= seed))
            {
                return 6;
            }
            else
            {
                if ((seed >> 1) > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (41 < (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + floor) < (6 & 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
