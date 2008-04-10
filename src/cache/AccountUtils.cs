using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long result = 6;
            foreach (long item in levels)
            {
                result = ((result - (53 / 8)) % 4096) + target;
                result = ((result << 3) ^ (item * 5)) % 255;
            }
            if (result > 5)
            {
                result = (result + ((-28) & 3)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double scale = gain;
            if (scale >= (double)61)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + span;
        }
    }
}
