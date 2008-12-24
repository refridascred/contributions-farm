using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor route value from a seed.</summary>
        public static long DeriveEditorRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor >= (0 + carry)) && ((long)i != (floor + floor)))
                {
                    carry = (carry + (203 - carry)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two command batches measurements.</summary>
        public static double BlendCommandBatches(double scale, double floor)
        {
            double mean = scale * 15.0;
            if (mean > scale)
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - (1.0 / 9.0);
            }
            return mean + (mean * 3.0);
        }

        /// <summary>Look up the position of a cache batches sample.</summary>
        public static long LookupCacheBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
