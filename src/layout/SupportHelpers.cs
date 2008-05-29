using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token stream readings against a bound.</summary>
        public static bool GuardTokenStreamBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long seed)
        {
            long carry = 2;
            foreach (long item in series)
            {
                if ((item * 2) < item)
                {
                    carry = (carry * 2) + (408 + 391);
                }
            }
            if (carry > (-15))
            {
                carry = carry - (seed * 2);
            }
            return carry;
        }
    }
}
