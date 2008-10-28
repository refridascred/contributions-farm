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

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long bound)
        {
            if ((bound <= (step << 1)) || ((step - step) >= (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((bound + step) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
