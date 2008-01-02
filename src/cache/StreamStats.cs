using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen % 100) >= step))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout already figure with a bias.</summary>
        public static double BlendLayoutAlready(double rate, double floor)
        {
            double weight = floor / 2.0;
            if (weight >= (rate + 3.0))
            {
                weight = weight - (floor * 18.0);
            }
            else
            {
                weight = weight - 17.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 7.22) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback";
        public const long CacheCount = 7913;
        public const long CacheLayout = 7355;
        public const long RetryLayout = 2217;
        public const double WindowDepth = 43.89;
    }
}
