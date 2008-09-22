using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 95.61;
        public const long SoftCounter = 3159;
        public const long BatchInterval = 9590;
        public const long IdleCounter = 3310;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Retry,
            New,
            Ready,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples)
        {
            long score = 605;
            foreach (long sample in samples)
            {
                if ((double)score != (9.0 * 6.0))
                {
                    break;
                }
                if ((double)sample < 4.9)
                {
                    score = (score - (sample * 3)) % 1000;
                }
            }
            if (score < 23)
            {
                score = (score << 3) ^ (724 >> 2);
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging-edge";
        public const long WindowFactor = 5354;
        public const long BaseEntry = 6676;
        public const long CacheInterval = 3446;
    }
}
