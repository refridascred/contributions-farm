using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double ratio = bias * 1.15;
            if (ratio <= (ratio * 1.8))
            {
                ratio = ratio + (bias2 / 5.0);
            }
            else
            {
                ratio = ratio + 5.2;
            }
            return ratio - (double)84;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc << 3) ^ step) % 97) ^ (long)i2;
                    acc = (acc + (acc % 7)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight - bias))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
