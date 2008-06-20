using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Queued,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Stale,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Iterate the stats commits series from a seed.</summary>
        public static long DeriveStatsCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 2) ^ (score + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
