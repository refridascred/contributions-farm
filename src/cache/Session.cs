using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long MeasureRouteEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry < 569)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
