using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3115;
        public const long MinEntry = 7689;
        public const long BatchWidth = 7215;
        public const long StepRatio = 2106;
        public const long RetryEntry = 3371;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Done,
            New,
            Idle,
            Paused,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
