using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)floor == (7.1 * 19.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long IterateMetricsProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6046;
        public const long MinBudget = 5232;
        public const long StepSize = 657;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item >> 4) != (item + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}
