using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "strict-1";
        public const long BatchCluster = 4239;
        public const long MaxScore = 7814;
        public const string RetryRatio = "alpha";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Stale,
            Queued,
            Closed,
        }
    }
}
