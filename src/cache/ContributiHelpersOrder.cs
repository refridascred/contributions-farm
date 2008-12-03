using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long seed)
        {
            long carry = -8;
            foreach (long cell in items)
            {
                carry = ((carry - (carry / 9)) % 255) ^ cell;
                if ((carry << 1) > seed)
                {
                    carry = carry - seed;
                }
                else
                {
                    carry = (carry + carry) % 101;
                }
            }
            return carry;
        }
    }
}
