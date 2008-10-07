using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "fallback-edge";
        public const string RetryWidth = "local-edge";
        public const string IdleCache = "open";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) >= (94 << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double ratio = (double)12 / 7.0;
            return (ratio + (offset * 10.0)) + scale;
        }
    }
}
