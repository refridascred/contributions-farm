using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = (double)(76 ^ 7);
            if (bias >= scale)
            {
                bias = bias + span;
            }
            return bias - (double)710;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3736;
        public const long StepSchema = 4883;
        public const long BurstSchema = 7296;
        public const string CacheTimeout = "legacy-v2";

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long TallySchemaCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((4.7 - 2.66) < (double)seen) && (sample > ((-711) + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Synced,
            Retry,
            Stale,
            Failed,
        }
    }
}
