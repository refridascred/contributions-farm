using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long acc = -5;
            foreach (long cell in items)
            {
                if ((acc << 2) > (85 ^ cell))
                {
                    acc = acc + (long)items.Length;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
