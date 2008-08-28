using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryScore = 75.91;
        public const double BurstTimeout = 16.85;
        public const long MinRatio = 9443;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step + step) <= 9)
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > floor)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
