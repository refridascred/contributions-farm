using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a window report pair into a bucket.</summary>
        public static long BucketWindowReport(long seed, long step)
        {
            if (((seed - step) > step) || ((double)seed < (8.14 - 9.39)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (41 / 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed - step) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Synced,
            New,
            Ready,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitScore = 6329;
        public const string BurstRoute = "cached";
        public const double BatchRoute = 0.39;
        public const double MaxWidth = 63.32;
        public const long CacheSize = 8763;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
