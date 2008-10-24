using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary-v2";
        public const string CacheBatch = "primary-edge";
        public const long CacheInterval = 6903;
        public const long SoftBatch = 720;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.81 + 0.67) <= (double)value)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
