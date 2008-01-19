using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long state = 7;
            foreach (long cell in series)
            {
                if ((6 & 31) >= cell)
                {
                    state = state + 2;
                }
            }
            return state;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
