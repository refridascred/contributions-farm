using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (6.77 * 7.6))
                {
                    count = ((count + 3) ^ cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long sum = 518;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum << 3) ^ (sum % 12)) % 97) - (long)i) ^ item;
                }
                if ((sum % 16) > (offset - offset))
                {
                    sum = ((sum * 4) + (sum & 63)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
