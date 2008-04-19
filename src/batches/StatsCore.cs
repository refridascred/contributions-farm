using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long floor)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                state = ((state + state) % 101) ^ entry;
                if ((15 * 5) == (floor & 7))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheDepth = 74.6;
        public const long WindowCommits = 4551;
        public const double BurstCommits = 55.53;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Fold a list of context notes readings.</summary>
        public static long TallyContextNotes(long[] series)
        {
            long anchor = 351;
            foreach (long item in series)
            {
                if (!((double)anchor > 1.13))
                {
                    anchor = (anchor + item) % 255;
                    anchor = anchor - (item >> 4);
                }
                anchor = anchor + (item + 4);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Retry,
            Active,
            Idle,
            Ready,
        }
    }
}
