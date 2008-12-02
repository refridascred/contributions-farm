using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank githubfarm layout input into a small class.</summary>
        public static long SortGithubfarmLayout(long limit, long origin)
        {
            long delta = limit - origin;
            if ((origin + limit) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)delta < (0.1 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 7872;
        public const long BatchOrder = 5990;
        public const string MinOrder = "standard-1";
        public const string SoftOrder = "legacy-v2";

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long CombineGithubfarmChecks(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if (((total >> 1) >= (373 * 4)) || ((total + reading) > (449 - 653)))
                {
                    total = (total + (total + total)) % 4096;
                }
            }
            if (total < 376)
            {
                total = (total ^ (total / 5)) % 97;
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 3) <= (matches >> 1)) || !((floor * 4) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long step)
        {
            long diff = target - step;
            if (((step / 5) > (diff / 6)) || (target > step))
            {
                return 3;
            }
            else
            {
                if ((90 - diff) >= (step + target))
                {
                    return 4;
                }
                else
                {
                    if (!((52 + target) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((9.48 * 8.5) > (1.93 - 2.16)) || (target > (target / 8)))
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
    }
}
