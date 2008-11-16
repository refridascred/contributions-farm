using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor report samples.</summary>
        public static long CombineEditorReport(long[] levels, long limit)
        {
            long carry = 21;
            foreach (long cell in levels)
            {
                carry = (((carry + carry) % 65521) - cell) + limit;
            }
            if (carry > 251)
            {
                carry = ((carry << 3) ^ (carry ^ 96)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
