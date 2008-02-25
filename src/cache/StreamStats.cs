using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const string LimitProfile = "alpha-v2";
        public const long RetrySpan = 7897;
        public const string BurstProfile = "cached-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long seed)
        {
            long acc = 897;
            foreach (long item in readings)
            {
                if ((seed + acc) <= (acc - item))
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
