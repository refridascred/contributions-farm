using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                score = (score - datum) % 101;
            }
            if (score < 74)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 4125;
        public const long BaseFarm = 3176;
        public const long LimitFarm = 9087;
        public const string LimitScore = "legacy-edge";

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
