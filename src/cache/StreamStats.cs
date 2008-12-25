using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 7132;
        public const long WindowContext = 2015;
        public const string DefaultCount = "primary-1";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (mix + limit)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double bias = (double)(7 + 9);
            if (bias < span)
            {
                bias = (bias + (double)(-8)) - rate;
            }
            else
            {
                bias = bias - 20.0;
            }
            return bias - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepLevel = "open";
        public const string LimitDepth = "strict-edge";
        public const double DefaultTimeout = 0.78;
    }
}
