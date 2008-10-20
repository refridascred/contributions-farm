using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = ((mix ^ (mix + mix)) % 65521) ^ value;
            }
            if (mix > 54)
            {
                mix = (mix ^ (mix ^ mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "strict-edge";
        public const double MaxScore = 94.52;
        public const string IdleScore = "primary";
        public const long HardInterval = 1471;
    }
}
