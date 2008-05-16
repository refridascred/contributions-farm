using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Paused,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardFactor = 62.07;
        public const double RetryNotes = 81.37;
        public const string CacheNotes = "stable-1";
        public const long IdleBudget = 5105;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheSpan = 7387;
        public const long BatchWidth = 6991;
        public const long HardTimeout = 1260;
    }
}
