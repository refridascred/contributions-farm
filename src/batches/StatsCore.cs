using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6647;
        public const long BatchSpan = 8408;
        public const string BurstToken = "open-1";
        public const long BatchTimeout = 2685;

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double mean = (double)(9 - 564);
            if (mean <= (double)91)
            {
                mean = (mean - (double)35) - scale;
            }
            return mean + span;
        }
    }
}
