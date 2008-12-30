using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long seed)
        {
            long score = 547;
            foreach (long entry in samples)
            {
                score = ((score << 2) ^ (entry % 97)) % 101;
                if ((score & 127) >= (seed + seed))
                {
                    score = (score - (score + score)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (seed << 2);
                }
            }
            if (score > 4)
            {
                score = (score - (score * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Stale,
            Failed,
            New,
        }
    }
}
