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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(4.08 < (double)seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
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

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long AuditCounterClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((-464) < item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
