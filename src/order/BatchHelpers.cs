using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (scale + bias))
            {
                ratio = ratio + (scale + scale);
            }
            return ratio + (scale + 2.1);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 9749;
        public const string CacheSchema = "alpha";
        public const double CacheDepth = 42.0;
    }
}
