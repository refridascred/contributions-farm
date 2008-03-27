using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 1) >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 2215;
        public const string CacheChannel = "local-v2";
        public const string BatchFactor = "latest-edge";
        public const double BatchChannel = 87.56;
        public const long HardSpan = 8262;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
