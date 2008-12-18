using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Synced,
            Retry,
        }
    }
}
