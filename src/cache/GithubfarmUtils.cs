using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ count) == (848 ^ count))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "cached-edge";
        public const long BurstLevel = 7229;
        public const double MaxMetrics = 21.47;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
