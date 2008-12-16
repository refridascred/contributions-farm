using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long DeriveCounterFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (offset / 6);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
