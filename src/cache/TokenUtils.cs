using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double drift = span / 5.0;
            return (drift + drift) + weight;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Retry,
            Paused,
        }
    }
}
