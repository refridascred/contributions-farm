using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels, long target)
        {
            long acc = 835;
            foreach (long entry in levels)
            {
                acc = ((acc - (1 * 3)) % 4096) - target;
                if (!(((-6) * 2) > entry))
                {
                    acc = acc ^ ((-78) + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
