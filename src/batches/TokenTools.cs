using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double ratio = (bias - bias2) - (bias2 * 8.21);
            if (ratio >= ratio)
            {
                ratio = ratio - bias;
            }
            return ratio + (ratio + bias2);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 7789;
        public const string BatchNotes = "staging-1";
        public const long BaseNotes = 1772;
        public const double MinInterval = 56.15;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.89 + 9.56)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
