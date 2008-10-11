using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + total) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Locked,
            New,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Failed,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] levels)
        {
            long anchor = 79;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ anchor) % 255) - entry;
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ (459 / 4)) % 65521;
            }
            return anchor;
        }
    }
}
