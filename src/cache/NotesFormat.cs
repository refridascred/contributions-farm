using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long carry = -320;
            foreach (long sample in data)
            {
                carry = ((carry ^ 70) + sample) + origin;
            }
            if (carry < 293)
            {
                carry = ((carry * 3) + (carry % 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >= (seen / 9)) || ((double)sample != (double)73))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
