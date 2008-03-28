using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item & 7) >= 436)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 7094;
        public const long RetryTimeout = 9798;
        public const double RetrySpan = 35.29;
        public const long BaseRatio = 9022;
        public const long IdleSpan = 9163;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 55.26;
        public const long DefaultTools = 579;
        public const string CacheTools = "fallback";
    }
}
