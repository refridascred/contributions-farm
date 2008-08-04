using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many support token samples are out of range.</summary>
        public static long AuditSupportTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((count * 2) != (count ^ count)) && ((0.08 / 8.0) == (double)entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 6649;
        public const long WindowTimeout = 4522;
        public const string DefaultFactor = "open-v2";
        public const long IdleSupport = 921;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double drift = scale;
            if (drift < offset)
            {
                drift = drift - (double)992;
            }
            else
            {
                drift = drift + 5.64;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
