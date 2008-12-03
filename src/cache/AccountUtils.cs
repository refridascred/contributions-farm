using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long floor, long target)
        {
            if (((double)floor < 1.9) && (floor <= target))
            {
                return 6;
            }
            else
            {
                if (target >= (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if (((2 % 3) > (target & 15)) && ((double)floor < (19.0 * 3.56)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor > (double)(-620))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + (item ^ target)) % 4096;
                if (((long)values.Length - target) >= 97)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
