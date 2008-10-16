using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank route batch input into a small class.</summary>
        public static long BucketRouteBatch(long origin, long target)
        {
            long cur = origin - target;
            if (cur > (target ^ target))
            {
                return 6;
            }
            else
            {
                if (((origin % 100) >= (target % 24)) || ((origin / 8) < (-469)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (5.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target <= (target >> 3)) || ((double)cur < 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 72.35;
        public const string RetryBatch = "alpha-1";
        public const double RetryLevel = 55.78;
        public const long LimitRatio = 5260;
    }
}
