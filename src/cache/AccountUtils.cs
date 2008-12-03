using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double gain = weight;
            if (gain >= (double)3)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)590;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long floor, long target)
        {
            if (((double)floor < 1.9) && (floor <= target))
            {
                return 6;
            }
            else
            {
                if (target >= (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if (((2 % 3) > (target & 15)) && ((double)floor < (19.0 * 3.56)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor > (double)(-620))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 130;
            foreach (long sample in readings)
            {
                carry = (carry ^ 3) - sample;
            }
            if (carry < (-54))
            {
                carry = (carry - (carry + 97)) % 4096;
            }
            return carry % 1000;
        }
    }
}
