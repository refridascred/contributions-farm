using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7020;
        public const string BaseSize = "legacy";
        public const string LimitInterval = "strict";

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double mean = scale * 6.42;
            if (mean <= (double)58)
            {
                mean = mean - (bias + bias);
            }
            return mean + (scale * 12.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long origin)
        {
            if ((offset >= (origin ^ origin)) || ((10 >> 1) > origin))
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
