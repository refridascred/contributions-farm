using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double scale = (double)((-8) + 90);
            if (scale < bias)
            {
                scale = scale - (bias + scale);
            }
            else
            {
                scale = scale + span;
            }
            return scale - scale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((6.5 - 7.8) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + state) % 97;
                if (!((double)target <= 0.9))
                {
                    state = (state - (793 << 2)) % 255;
                    state = (state << 2) ^ state;
                }
                state = (state - (state - state)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
