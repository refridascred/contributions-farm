using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long DigestBatchesAccount(long[] values, long bound)
        {
            long anchor = 85;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (entry * 5)) % 1000) - bound;
            }
            return anchor % 97;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
