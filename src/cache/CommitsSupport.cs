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

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
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
