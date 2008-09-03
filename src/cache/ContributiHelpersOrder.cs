using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 5) > 3)
                {
                    carry = (carry ^ carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double mean = rate;
            if (mean > (span + mean))
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 8.4) + (double)(long)i;
            }
            return mean + (mean - rate);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 1803;
        public const double LimitStats = 46.31;
        public const long BaseStats = 8859;
        public const double MinDepth = 15.57;
    }
}
