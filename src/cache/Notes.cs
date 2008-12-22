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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2133;
        public const double LimitWidth = 46.19;
        public const long BatchFormat = 885;
        public const long IdleLevel = 6342;
    }
}
