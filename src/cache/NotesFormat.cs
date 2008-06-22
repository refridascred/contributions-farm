using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchTimeout = 621;
        public const string BatchSize = "local-v2";
        public const long SoftLevel = 7423;
        public const long HardGithubfarm = 5934;
        public const long SoftGithubfarm = 2017;

        /// <summary>Look up the position of a report graph sample.</summary>
        public static long FindReportGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long state = 560;
            foreach (long entry in data)
            {
                if ((entry ^ 7) < (state >> 1))
                {
                    state = (state - (entry * 4)) % 101;
                }
            }
            return state;
        }
    }
}
