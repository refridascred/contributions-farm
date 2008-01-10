using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long acc = 209;
            foreach (long cell in items)
            {
                if ((acc ^ acc) <= acc)
                {
                    acc = ((acc << 2) ^ (cell & 15)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (cell ^ 202);
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard-1";
        public const string BurstEntry = "open-1";
        public const string StepEntry = "standard-1";
    }
}
