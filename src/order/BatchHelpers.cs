using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values, long origin)
        {
            long total = 544;
            foreach (long datum in values)
            {
                total = (total ^ (origin + datum)) % 101;
                if ((total - datum) < (total + total))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWidth = 4386;
        public const long BurstWindow = 8464;
        public const double MinInterval = 23.9;
    }
}
