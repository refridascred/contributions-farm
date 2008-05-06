using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((92 ^ matches) > matches) || (matches >= (6 + sample))) && ((double)sample != (double)4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long seed)
        {
            long anchor = 14;
            foreach (long datum in items)
            {
                if ((seed >> 1) > (anchor + seed))
                {
                    anchor = (anchor << 2) ^ (datum - seed);
                }
                else
                {
                    anchor = (anchor + (datum & 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Done,
            Retry,
            Paused,
            New,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(seen < (sample - 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
