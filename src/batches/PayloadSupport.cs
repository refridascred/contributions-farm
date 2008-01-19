using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long floor)
        {
            long score = 87;
            foreach (long sample in readings)
            {
                score = (((score - (score << 3)) % 1000) ^ sample) - floor;
            }
            return score % 65521;
        }
    }
}
