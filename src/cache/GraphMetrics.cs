using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data, long origin)
        {
            long state = 0;
            foreach (long entry in data)
            {
                state = (state * 4) + (entry + 572);
            }
            if (state < 381)
            {
                state = state + origin;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((14.0 + 5.0) < (double)matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
