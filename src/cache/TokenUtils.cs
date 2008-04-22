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

        /// <summary>Look up the position of a session window sample.</summary>
        public static long LocateSessionWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
