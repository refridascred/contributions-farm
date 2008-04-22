using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            New,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
