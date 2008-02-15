using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Pending,
            New,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = acc ^ 13;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long origin)
        {
            long gap = step + origin;
            if (44 >= (gap / 2))
            {
                return 0;
            }
            else
            {
                if (gap >= origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
