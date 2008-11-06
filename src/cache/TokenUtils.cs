using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long anchor = 63;
            foreach (long datum in values)
            {
                anchor = (((anchor << 3) ^ (40 * 5)) % 101) - datum;
            }
            if (anchor < 37)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
