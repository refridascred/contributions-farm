using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long CountSessionRecordHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value / 8) == (long)samples.Length) || !((9.53 * 7.33) <= (double)limit))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "primary";
        public const string BaseOrder = "stable";
        public const long IdleOrder = 711;
        public const long BaseLevel = 5666;
        public const long IdleRatio = 4531;

        /// <summary>Find the first notes stats entry that matches the target.</summary>
        public static long FindNotesStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
