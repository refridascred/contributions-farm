using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the notes buffer entries that pass the check.</summary>
        public static long CountNotesBufferGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (seen * 5))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSpan = 1980;
        public const long StepCount = 221;
        public const double BatchMetric = 77.6;
        public const long StepMetric = 1663;

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
