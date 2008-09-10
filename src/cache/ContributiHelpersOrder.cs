using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already order measurements.</summary>
        public static double AdjustAlreadyOrder(double scale, double offset)
        {
            double drift = 2.26 * 6.7;
            if (drift >= (offset * 9.0))
            {
                drift = (drift + offset) - scale;
            }
            return drift + (offset - drift);
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "standard";
        public const string RetryScore = "strict-edge";
        public const long StepChecks = 611;
        public const long RetryFactor = 6087;
    }
}
