using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2349;
        public const long LimitPayload = 4235;
        public const double MaxPayload = 46.09;
        public const double BatchPayload = 93.41;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((target >> 2) < (entry & 63)) || (4 >= (entry + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long BucketSessionOrder(long target, long seed)
        {
            if ((double)seed >= (0.79 - 4.3))
            {
                return 8;
            }
            else
            {
                if (((target ^ seed) >= seed) || ((target - 468) < (target + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((67 < target) && ((target >> 3) == (7 + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((662 + target) <= (4 - 0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 7726;
        public const long DefaultFilter = 2029;
        public const string LimitTimeout = "alpha-v2";
        public const long BurstScore = 6658;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
