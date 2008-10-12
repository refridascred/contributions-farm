using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxInterval = 685;
        public const long StepInterval = 8755;
        public const double BaseOrder = 16.06;
        public const string SoftFactor = "strict-edge";
        public const string MaxTimeout = "standard-1";

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
