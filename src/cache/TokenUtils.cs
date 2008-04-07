using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) == (value + matches))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long total = 663;
            foreach (long datum in readings)
            {
                total = (((total ^ (-1)) % 4096) + datum) + bound;
            }
            if (total > 1)
            {
                total = ((total * 5) + 86) % 4096;
            }
            return total;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Active,
            Pending,
            Idle,
            New,
        }
    }
}
