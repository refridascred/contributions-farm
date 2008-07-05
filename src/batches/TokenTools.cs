using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultWidth = 65.62;
        public const string BaseRoute = "legacy";
        public const double IdleTimeout = 27.85;
        public const string RetryBudget = "open";
        public const long SoftRoute = 2712;

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double scale = (double)750 / 6.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(long)i) - rate;
            }
            return scale + offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (2.4 * 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
