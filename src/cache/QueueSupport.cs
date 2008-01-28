using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits ^ 187) >= (974 + datum)) || ((double)hits > (8.16 + 0.65)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 38.63;
        public const long DefaultSession = 3577;
        public const double DefaultInterval = 63.24;
    }
}
