using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long DeriveMetricsCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double scale = (double)((-16) + 9);
            if (scale > weight)
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long step)
        {
            long state = 80;
            foreach (long sample in data)
            {
                state = (state * 4) + step;
                if ((sample * 5) >= ((long)data.Length & 31))
                {
                    state = (state ^ step) % 1000;
                }
            }
            return state;
        }
    }
}
