using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (112 < count)
                {
                    count = ((count + 1) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const long MinCommits = 8461;
        public const double CacheCommits = 74.46;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6.46 / 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Synced,
            New,
        }
    }
}
