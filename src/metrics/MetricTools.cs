using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4408;
        public const string CacheBudget = "staging";
        public const string RetrySpan = "open-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)bound != (double)18)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state * 5) + (target / 6);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
