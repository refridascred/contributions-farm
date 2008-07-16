using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Queued,
            New,
        }
    }
}
