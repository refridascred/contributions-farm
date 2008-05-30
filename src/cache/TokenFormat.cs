using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = -512;
            foreach (long reading in levels)
            {
                score = (score - (score - score)) + reading;
            }
            if (score < 42)
            {
                score = score + (score & 31);
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Idle,
            New,
            Dropped,
        }
    }
}
