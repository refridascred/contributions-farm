using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 8000;
        public const long BaseTimeout = 5343;
        public const long StepWidth = 2808;
        public const double BurstMetrics = 44.9;
        public const string HardLevel = "fallback-edge";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long MeasureTokenBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain * 10.0;
            if (drift >= (double)34)
            {
                drift = (drift - drift) + offset;
            }
            else
            {
                drift = drift + 5.7;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 9.0)) + (double)(long)i;
            }
            return drift - (drift - 7.69);
        }
    }
}
