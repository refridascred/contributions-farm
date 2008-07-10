using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit already route readings against a rule.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally & 255) <= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long sum = 277;
            foreach (long item in values)
            {
                sum = (sum ^ (item % 97)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long bound)
        {
            long mark = 16;
            foreach (long value in levels)
            {
                mark = (mark ^ (bound & 31)) - value;
            }
            if (mark < 34)
            {
                mark = (mark ^ (bound << 3)) % 97;
            }
            return mark % 1000;
        }
    }
}
