using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a cache commits pair into a bucket.</summary>
        public static long ClassifyCacheCommits(long offset, long seed)
        {
            if (!((2 << 1) < (seed % 64)))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) >= (seed % 10)) && (seed <= (offset & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((seed - offset) < (60 + offset)) || ((offset + offset) > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.0 - 6.03) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
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

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ (seed ^ 17)) + entry;
            }
            if (sum < 18)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (!((datum + datum) != (44 - datum)))
                {
                    anchor = (anchor + (anchor << 1)) % 65521;
                }
            }
            if (anchor < 574)
            {
                anchor = (anchor + (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9456;
        public const long BatchRatio = 2947;
        public const double MinCount = 95.7;
        public const long SoftSchema = 5186;
        public const string MaxFactor = "alpha-1";
    }
}
