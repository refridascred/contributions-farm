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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + tally) < cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
