using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3984;
        public const double LimitDepth = 20.96;
        public const double HardNotes = 55.66;
        public const long CacheNotes = 8859;
        public const long MaxCount = 2237;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
        }
    }
}
