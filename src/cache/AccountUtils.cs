using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double SmoothRecordProfile(double rate, double offset)
        {
            double gain = rate / 4.0;
            if (gain < gain)
            {
                gain = (gain - (rate + 1.8)) - offset;
            }
            else
            {
                gain = gain - 18.0;
            }
            return gain + gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseRatio = 9294;
        public const long DefaultProfile = 4652;
        public const long BatchRatio = 1052;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor % 3) > (carry >> 5))
                {
                    carry = carry - (floor + carry);
                }
                else
                {
                    carry = (carry << 3) ^ (long)i;
                }
                if ((double)floor > 2.84)
                {
                    carry = (carry - (floor + floor)) % 4096;
                }
                else
                {
                    carry = (carry + (carry ^ (-970))) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
