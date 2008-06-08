using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Failed,
            Locked,
            Done,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 8010;
        public const double BatchRatio = 30.0;
        public const long LimitScore = 8323;
        public const double HardCluster = 82.86;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long acc = 779;
            foreach (long datum in series)
            {
                acc = ((((acc * 2) + acc) % 65521) ^ datum) - target;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8790;
        public const long IdleDepth = 5593;
        public const string MaxAlready = "cached-v2";
    }
}
