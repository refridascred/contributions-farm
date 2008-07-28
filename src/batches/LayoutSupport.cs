using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double rate, double bias)
        {
            double mean = rate;
            if (mean >= (rate + 17.0))
            {
                mean = (mean + rate) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (rate / 2.0);
        }

        /// <summary>Derive the next window tools value from a seed.</summary>
        public static long SeriesWindowTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4105;
        public const double RetryBuffer = 97.62;
        public const string MinTimeout = "alpha-edge";
    }
}
