using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + bound) % 255;
                mix = mix + (bound & 15);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Stale,
            New,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2133;
        public const double LimitWidth = 46.19;
        public const long BatchFormat = 885;
        public const long IdleLevel = 6342;
    }
}
