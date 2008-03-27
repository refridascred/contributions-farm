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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((bound + cell) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
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
