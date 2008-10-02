using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long TallyBatchCommits(long[] readings)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                carry = (carry ^ (value >> 3)) % 97;
            }
            if (carry < 412)
            {
                carry = ((carry << 3) ^ (carry << 1)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 6;
            foreach (long item in levels)
            {
                state = (state ^ (origin ^ item)) % 97;
            }
            return state;
        }
    }
}
