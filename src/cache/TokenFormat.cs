using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchLevel = 2672;
        public const long BurstSize = 2995;
        public const long CacheWindow = 1971;

        /// <summary>Rank counter checks input into a small class.</summary>
        public static long BucketCounterChecks(long target, long limit)
        {
            if (((58 ^ limit) == (target << 1)) && ((double)target >= (7.6 * 4.4)))
            {
                return 1;
            }
            else
            {
                if (target < (target + 3))
                {
                    return 0;
                }
                else
                {
                    if ((target % 10) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 3) < target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound > (bound << 1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
