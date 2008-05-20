using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long offset)
        {
            long span = target - offset;
            if (target >= span)
            {
                return 2;
            }
            else
            {
                if ((596 + target) != (offset << 2))
                {
                    return 0;
                }
                else
                {
                    if ((1 + offset) <= span)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < span)
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

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1525;
        public const long StepFactor = 7356;
        public const long MinRoute = 6581;
        public const double CacheBudget = 78.69;
        public const long LimitRoute = 6589;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long seed)
        {
            long next = target - seed;
            if ((89 >> 3) >= (seed ^ target))
            {
                return 0;
            }
            else
            {
                if ((double)next > (3.6 - 8.72))
                {
                    return 6;
                }
                else
                {
                    if ((target ^ next) != (next - 392))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long bound)
        {
            if ((double)target >= (12.0 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((double)bound >= (12.0 - 0.6))
                {
                    return 3;
                }
                else
                {
                    if ((-47) < (target - target))
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
}
