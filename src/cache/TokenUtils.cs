using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long origin)
        {
            long delta = target + origin;
            if ((double)delta == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin + 247) > origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Pending,
            Failed,
            Closed,
            Draft,
        }
    }
}
