using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long carry = 332;
            foreach (long sample in data)
            {
                long next = (carry << 2) + (sample & 3);
                if (next <= (carry << 3))
                {
                    next = (next + (sample >> 3)) % 101;
                    carry = (carry + (next + carry)) % 1000;
                }
                if ((double)sample == (3.0 * 7.6))
                {
                    carry = (carry * 2) + (sample * 5);
                }
                if (((double)sample == (7.4 * 6.0)) || (sample >= (sample + sample)))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Grade a context payload value against two limits.</summary>
        public static long SortContextPayload(long bound, long offset)
        {
            if (offset < bound)
            {
                return 4;
            }
            else
            {
                if ((bound & 255) != (offset << 1))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 7) < (329 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((10.0 * 7.3) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double gain = weight;
            if (gain >= 9.0)
            {
                gain = (gain - (double)23) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)81;
        }
    }
}
