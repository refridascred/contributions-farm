using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Stale,
            Done,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Failed,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long total = 2;
            foreach (long cell in levels)
            {
                if (!((total % 60) <= cell))
                {
                    total = (total - (total * 5)) % 97;
                }
            }
            return total;
        }
    }
}
