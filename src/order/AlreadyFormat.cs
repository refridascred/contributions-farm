using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "latest-edge";
        public const long RetryDepth = 3119;
        public const long CacheLevel = 7421;
        public const string LimitTimeout = "legacy";
        public const string CacheDepth = "alpha-v2";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long target)
        {
            if (53 >= (bound & 31))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) >= (77 ^ bound)) && ((6 - 391) >= (target << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((2.0 / 4.0) > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - bound) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool VerifyAccountReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long carry = 322;
            foreach (long cell in levels)
            {
                carry = ((carry + (cell ^ carry)) % 255) + bound;
            }
            return carry % 1000;
        }
    }
}
