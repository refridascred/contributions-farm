using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            New,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Closed,
            Done,
            Failed,
            Dropped,
        }
    }
}
