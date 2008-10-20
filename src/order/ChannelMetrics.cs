using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
