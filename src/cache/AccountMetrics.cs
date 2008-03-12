using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count batches report pairs that satisfy a relation.</summary>
        public static long MatchBatchesReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - 13) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long carry = -815;
            foreach (long cell in levels)
            {
                if ((double)cell >= 20.0)
                {
                    carry = (carry * 4) + (carry + carry);
                }
                else
                {
                    carry = (carry + (cell << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (offset >= (item ^ 402))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 255;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry < 53)
            {
                carry = (carry + (61 * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
