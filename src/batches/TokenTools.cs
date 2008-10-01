using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit <= sample) || ((double)seen >= 8.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit stream layout readings against a rule.</summary>
        public static long TallyStreamLayoutMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (seed <= ((long)levels.Length % 97))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
