using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Done,
            New,
            Idle,
            Paused,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                if (carry <= (cell % 5))
                {
                    carry = (carry - 0) % 1000;
                }
            }
            if (carry < 513)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry % 65521;
        }
    }
}
