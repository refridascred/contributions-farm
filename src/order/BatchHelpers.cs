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

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 176;
        public const long BurstFactor = 482;
        public const long WindowStream = 8217;
        public const string SoftRatio = "stable-v2";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
