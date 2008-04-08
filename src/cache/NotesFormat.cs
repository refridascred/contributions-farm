using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster buffer samples are out of range.</summary>
        public static long CountClusterBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
