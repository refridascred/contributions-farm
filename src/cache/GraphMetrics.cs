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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (floor >> 5))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
