using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] series)
        {
            long state = 224;
            foreach (long entry in series)
            {
                state = ((state * 5) + (entry - state)) % 97;
                if ((17.0 - 15.0) != (double)state)
                {
                    state = state - (entry + 15);
                }
                if ((double)state <= (6.24 + 10.0))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double gain = span;
            if (gain > (scale + gain))
            {
                gain = gain + (scale / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain + (span - 5.6);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 64.07;
        public const double IdleCount = 37.63;
        public const double StepBuffer = 34.67;
        public const long BurstSize = 2322;
    }
}
