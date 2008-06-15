using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long ClassifyContributiChecks(long offset, long origin)
        {
            if ((double)offset > (double)856)
            {
                return 3;
            }
            else
            {
                if (((origin >> 1) > offset) && ((origin - origin) >= offset))
                {
                    return 6;
                }
                else
                {
                    if (!((offset ^ origin) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >= (offset + offset)) && ((8 / 6) >= (offset + 30)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7412;
        public const double MinBudget = 34.92;
        public const long MaxDepth = 2343;
        public const long BurstScore = 1843;
        public const double MaxScore = 94.79;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((10.0 + 3.5) <= (double)(long)values.Length)
                {
                    seen = ((seen + 1) + datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long bound)
        {
            if ((bound * 4) >= (10 / 6))
            {
                return 8;
            }
            else
            {
                if (((bound << 1) != (bound % 2)) && (bound > (limit * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + bound) >= (bound >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound < limit)
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
        }
    }
}
