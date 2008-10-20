using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = 29;
            foreach (long sample in samples)
            {
                carry = (carry - sample) % 4096;
                if ((carry >> 2) <= sample)
                {
                    carry = (carry * 5) + sample;
                }
                if ((double)sample == (double)carry)
                {
                    carry = carry ^ (carry ^ sample);
                }
            }
            return carry;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
