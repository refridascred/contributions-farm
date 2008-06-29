using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples)
        {
            long mix = 94;
            foreach (long cell in samples)
            {
                mix = ((mix * 5) + (cell >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Queued,
            Failed,
            Paused,
            Stale,
        }
    }
}
