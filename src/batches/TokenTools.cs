using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long MeasureCounterBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double scale = (3.0 / 9.0) * 20.0;
            if (scale <= (double)4)
            {
                scale = (scale - (double)2) - bias2;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + scale;
        }
    }
}
