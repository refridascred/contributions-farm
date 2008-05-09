using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "cached-edge";
        public const long DefaultSpan = 9290;
        public const double BurstChannel = 8.88;
        public const string WindowInterval = "staging";
        public const string LimitChannel = "standard-v2";

        /// <summary>Count the schema githubfarm entries that pass the check.</summary>
        public static long CountSchemaGithubfarmHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (seed >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
