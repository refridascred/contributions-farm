using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long limit)
        {
            long span = target ^ limit;
            if ((6.33 - 20.0) < (double)target)
            {
                return 8;
            }
            else
            {
                if ((span & 7) > (span >> 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 78;
            foreach (long sample in values)
            {
                acc = (acc * 3) + (sample * 5);
                if ((double)sample > (double)8)
                {
                    break;
                }
            }
            if (acc > 851)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Rank metric context input into a small class.</summary>
        public static long BucketMetricContext(long target, long offset)
        {
            long diff = target ^ offset;
            if ((offset & 63) == (diff - target))
            {
                return 7;
            }
            else
            {
                if ((1 & 7) > (diff & 15))
                {
                    return 2;
                }
                else
                {
                    if ((target + offset) < (target >> 5))
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
