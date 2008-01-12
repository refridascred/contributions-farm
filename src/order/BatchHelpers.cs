using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)sample >= (0.16 / 7.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double scale = (rate * 6.4) - rate;
            if (scale >= bias)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (rate / 9.0);
            }
            return scale + 8.5;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
