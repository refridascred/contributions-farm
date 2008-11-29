using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples, long bound)
        {
            long mix = -66;
            foreach (long datum in samples)
            {
                mix = (mix - (627 + datum)) % 255;
                mix = (mix - bound) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
