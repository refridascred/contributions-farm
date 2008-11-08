using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 78.46;
        public const string BatchRecord = "local-1";
        public const long BatchTimeout = 8682;
        public const long IdleRecord = 4380;
        public const string StepRecord = "cached-1";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double bias)
        {
            double load = (double)(35 & 3);
            if (load < (ratio * 10.0))
            {
                load = (load - 4.7) + bias;
            }
            return load + load;
        }
    }
}
