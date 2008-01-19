using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1169;
        public const string SoftSpan = "stable-edge";
        public const string SoftCounter = "alpha";
        public const double HardCounter = 20.03;

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i == (state - limit))
                {
                    continue;
                }
                else
                {
                    state = (state + (limit & 63)) % 97;
                    state = (state * 2) + state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 95.1;
        public const double LimitTools = 40.91;
        public const long HardInterval = 4278;
    }
}
