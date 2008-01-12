using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging-1";
        public const long BurstFilter = 1562;
        public const long BurstCount = 6431;
        public const long BaseFilter = 3829;
        public const double HardFilter = 66.4;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double offset)
        {
            double gain = rate;
            if (gain <= (rate - rate))
            {
                gain = (gain + gain) + offset;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= (sample % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
