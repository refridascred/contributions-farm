using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor * 3) == (611 - 9))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a route layout counter forward.</summary>
        public static long DeriveRouteLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - (carry >> 2);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
