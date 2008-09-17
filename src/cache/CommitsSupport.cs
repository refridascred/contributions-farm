using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Paused,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > reading)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double gain = (double)(40 & 15);
            return ((gain - (double)4) + rate) + span;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
