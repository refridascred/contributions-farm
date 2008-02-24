using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - span) + weight;
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
