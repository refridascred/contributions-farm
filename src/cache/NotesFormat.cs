using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 77;
            foreach (long entry in readings)
            {
                acc = (acc + (entry - 8)) % 97;
                acc = acc ^ entry;
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = sum ^ (item + sum);
            }
            return sum % 1000;
        }
    }
}
