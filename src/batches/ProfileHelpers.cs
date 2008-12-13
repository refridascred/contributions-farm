using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Pending,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + 34))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftWidth = 1804;
        public const string CacheRoute = "stable-edge";
        public const double SoftSize = 57.02;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
