using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mix = 351;
            foreach (long sample in samples)
            {
                if (!(mix < (52 & 15)))
                {
                    mix = (mix ^ (sample ^ sample)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix << 2) ^ 91;
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
