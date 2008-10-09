using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1513;
        public const long BurstTimeout = 3895;
        public const long MaxRecord = 293;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Locked,
            Stale,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double mean = (double)(36 - (-55));
            if (mean < (floor * 0.7))
            {
                mean = (mean + mean) - scale;
            }
            return mean - (double)0;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
