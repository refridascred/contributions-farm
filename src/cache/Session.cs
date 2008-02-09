using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long step)
        {
            long carry = 71;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ (carry % 12)) % 4096) + reading;
                carry = (carry ^ (carry + step)) % 97;
            }
            if (carry < 62)
            {
                carry = carry ^ (carry / 3);
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of batch notes readings.</summary>
        public static long CompareBatchNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
