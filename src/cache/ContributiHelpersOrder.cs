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

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long TallyStreamMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 1) != ((long)values.Length * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
