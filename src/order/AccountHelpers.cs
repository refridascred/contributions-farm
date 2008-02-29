using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((449 - 6) <= (sample << 2))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4758;
        public const long BatchFactor = 7221;
        public const long SoftSize = 247;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
