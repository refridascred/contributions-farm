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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long seed)
        {
            long next = target + seed;
            if ((double)seed < (double)target)
            {
                return 5;
            }
            else
            {
                if ((next % 10) < seed)
                {
                    return 2;
                }
                else
                {
                    if (!((16.0 - 8.9) >= 4.02))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((53 / 3) <= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
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
