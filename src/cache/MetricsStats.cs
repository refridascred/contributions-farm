using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Idle,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Done,
            Closed,
            Synced,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "fallback-v2";
        public const string DefaultInterval = "standard-1";
        public const double MaxCount = 15.72;
        public const long BatchTimeout = 5793;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= 203)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
