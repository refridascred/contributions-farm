using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Closed,
            Done,
            Dropped,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Synced,
            New,
            Ready,
            Done,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (target % 16)) % 97) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
