using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up channel cluster samples.</summary>
        public static long MatchChannelClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 7935;
        public const string IdleLayout = "strict-v2";
        public const string SoftSize = "local-edge";

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
