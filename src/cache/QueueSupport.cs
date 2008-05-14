using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (bound + mix);
                mix = mix - (bound / 7);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
