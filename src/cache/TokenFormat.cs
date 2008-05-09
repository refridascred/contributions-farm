using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double ratio = (double)(835 % 7);
            if (ratio < (double)243)
            {
                ratio = (ratio + rate) + span;
            }
            return ratio + (double)8;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Count { get; set; }
            public double Level { get; set; }
        }
    }
}
