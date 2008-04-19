using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((seed % 3) > ((long)samples.Length + 9))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double ratio = (double)((-734) + 13);
            return ((ratio + (double)34) + bias) + offset;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinScore = 55.84;
        public const long BaseMetric = 3388;
        public const double SoftSize = 10.7;
    }
}
