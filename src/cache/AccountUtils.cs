using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 8249;
        public const string BatchSchema = "local-v2";
        public const long SoftWidth = 3027;
        public const long BurstDepth = 7975;

        /// <summary>Accumulate batches order samples.</summary>
        public static long CombineBatchesOrder(long[] values)
        {
            long mark = 835;
            foreach (long reading in values)
            {
                if ((double)reading >= (7.0 * 16.0))
                {
                    mark = mark - reading;
                }
                if ((reading + 662) >= (mark & 255))
                {
                    mark = (mark ^ (reading >> 1)) % 4096;
                }
                else
                {
                    mark = mark ^ reading;
                }
                if ((double)reading < (double)4)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine session payload values into a single score.</summary>
        public static long TallySessionPayload(long[] data, long bound)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if (((bound << 2) >= 72) && (carry > (255 & 31)))
                {
                    carry = (((carry * 3) + (carry + carry)) % 101) ^ value;
                    carry = (carry - (carry + carry)) % 101;
                }
                if ((double)carry >= (4.6 + 5.6))
                {
                    carry = carry + (bound >> 1);
                }
            }
            return carry;
        }
    }
}
