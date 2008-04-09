using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long offset)
        {
            if ((double)offset < (5.23 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) <= (47 ^ origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Ready,
            Locked,
            Paused,
        }
    }
}
