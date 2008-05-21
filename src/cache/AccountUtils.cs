using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ ((long)i / 4)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next metric order value.</summary>
        public static double SmoothMetricOrder(double rate, double bias)
        {
            double ratio = (double)(2 + (-7));
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) + rate) - bias;
            }
            return ratio + (double)56;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches << 1) != (value % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
