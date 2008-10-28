using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (floor * 3.34)) + (double)(long)i) - rate;
            }
            return gain + (5.0 / 9.0);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                if ((mix + mix) > (item & 15))
                {
                    mix = (mix ^ (item + item)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (item + mix)) % 4096;
                }
            }
            if (mix < 63)
            {
                mix = (mix * 2) + (mix % 5);
            }
            return mix % 65521;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (carry - offset);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long WeighSupportBuffer(long[] readings)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.04 - 5.44))
                {
                    mix = ((mix << 3) ^ (mix ^ reading)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
