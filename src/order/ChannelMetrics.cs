using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >= (335 & 255)) && (((long)i - carry) < bound))
                {
                    carry = carry ^ (carry % 12);
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry + carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
