using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 3396;
        public const long RetryQueue = 6845;
        public const double DefaultSpan = 41.17;
        public const double MinSpan = 30.55;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Find the first payload record entry that matches the target.</summary>
        public static long LocatePayloadRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
