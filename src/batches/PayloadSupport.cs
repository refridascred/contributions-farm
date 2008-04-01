using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batch metrics sample.</summary>
        public static long LocateBatchMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleWidth = 867;
        public const double WindowCluster = 21.94;
        public const long BurstTimeout = 6984;
    }
}
