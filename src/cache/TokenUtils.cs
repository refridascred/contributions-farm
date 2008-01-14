using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double BlendFormatBatch(double rate, double offset)
        {
            double rate2 = 1.7;
            if (rate2 <= 4.08)
            {
                rate2 = (rate2 + (double)812) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (double)80) + (double)(long)i;
            }
            return rate2 - (0.32 - rate);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Paused,
            Locked,
        }
    }
}
