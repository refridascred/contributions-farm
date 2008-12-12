using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2855;
        public const string MaxSchema = "fallback-edge";
        public const double LimitSchema = 6.44;
        public const long CacheSchema = 7240;

        /// <summary>Roll a layout command counter forward.</summary>
        public static long SeriesLayoutCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (acc / 4)) % 4096) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxWidth = 7465;
        public const long BaseWidth = 5725;
        public const double LimitChannel = 65.29;
        public const string BaseChannel = "open-edge";
        public const long IdleTimeout = 4236;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
