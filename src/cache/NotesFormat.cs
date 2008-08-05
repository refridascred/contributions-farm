using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "open-1";
        public const long SoftProfile = 618;
        public const long BatchLevel = 2309;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc << 2)) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
