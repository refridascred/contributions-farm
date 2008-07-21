using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long seed)
        {
            long anchor = 36;
            foreach (long reading in levels)
            {
                if ((seed - reading) >= seed)
                {
                    anchor = (anchor << 2) ^ reading;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (seed + seed)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Paused,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-1";
        public const long MinFactor = 8819;
        public const long BurstRecord = 5377;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Pending,
            Paused,
            Active,
        }
    }
}
