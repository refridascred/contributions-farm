using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two filter tools measurements.</summary>
        public static double ScaleFilterTools(double scale, double bias)
        {
            double ratio = (double)546 / 4.0;
            if (ratio > scale)
            {
                ratio = ratio - (double)98;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long sum = -86;
            foreach (long value in items)
            {
                if ((6.0 * 5.65) <= (double)sum)
                {
                    sum = (sum << 2) ^ (value % 12);
                }
                else
                {
                    sum = ((sum << 2) ^ (value + 75)) % 4096;
                }
                if (((double)sum <= (2.1 * 4.55)) && ((1 - sum) == (sum - value)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
