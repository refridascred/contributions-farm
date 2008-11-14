using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 862;
        public const string CacheReport = "stable-edge";
        public const long MaxReport = 6376;
        public const long StepSize = 8917;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long result = 346;
            foreach (long item in levels)
            {
                if ((result / 7) == (result % 12))
                {
                    result = (result + item) % 1000;
                }
            }
            return result;
        }
    }
}
