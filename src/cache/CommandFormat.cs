using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a buffer notes sample.</summary>
        public static long LookupBufferNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)hits)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Retry,
            Stale,
            Paused,
        }
    }
}
