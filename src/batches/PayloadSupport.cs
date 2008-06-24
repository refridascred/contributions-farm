using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)target >= (9.55 + 10.0))
            {
                return 3;
            }
            else
            {
                if (5.9 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target > bound) || ((17.0 + 2.8) == (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long DigestQueueStats(long[] items)
        {
            long carry = 217;
            foreach (long entry in items)
            {
                carry = (((carry * 4) + (carry & 3)) % 101) ^ entry;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry & 63)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long offset)
        {
            long total = 20;
            foreach (long reading in series)
            {
                if ((8.02 / 2.0) != (double)total)
                {
                    total = (total * 3) + reading;
                }
                else
                {
                    total = (total + 719) % 1000;
                }
                if ((offset & 63) > (total - total))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
