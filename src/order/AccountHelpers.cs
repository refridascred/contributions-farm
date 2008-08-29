using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long carry = -4;
            foreach (long item in samples)
            {
                if ((3.61 * 11.0) < (double)carry)
                {
                    carry = (carry + (carry * 4)) ^ item;
                }
                else
                {
                    carry = (carry + (8 * 2)) % 4096;
                }
            }
            return carry;
        }

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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

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
