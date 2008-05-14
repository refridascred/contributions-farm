using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
