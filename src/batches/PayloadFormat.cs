using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 3125;
        public const long WindowScore = 9760;
        public const long StepLayout = 3497;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7476;
        public const long DefaultSize = 9744;
        public const double HardBudget = 1.63;
        public const long IdleBudget = 8104;
        public const long BurstStats = 3762;

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double scale = (double)669 * 7.8;
            if (scale <= (scale * 11.0))
            {
                scale = scale + (0.7 * 1.7);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (weight * 3.67)) + (double)(long)i;
            }
            return scale + (bias * 3.24);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)floor >= (9.0 + 5.2)))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
