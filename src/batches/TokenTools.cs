using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = -96;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ item) % 101;
                carry = (carry << 3) ^ item;
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < (gain * 12.0))
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (gain * 5.6)) + (double)(long)i;
            }
            return bias2 - (double)29;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = score + (step ^ (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    score = (score ^ (score - score)) - (long)i3;
                    score = (score ^ score) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
