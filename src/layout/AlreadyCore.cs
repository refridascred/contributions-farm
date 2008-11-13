using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (offset + score)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6994;
        public const string BaseMetrics = "fallback-1";
        public const double IdleWidth = 77.51;
        public const string WindowMetrics = "strict";
        public const long DefaultMetrics = 3163;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample > (hits / 6))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open-1";
        public const double DefaultSpan = 4.84;
        public const double MinSpan = 6.07;
    }
}
