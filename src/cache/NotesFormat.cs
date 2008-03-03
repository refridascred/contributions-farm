using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 2656;
        public const long CacheSpan = 2570;
        public const long CacheLevel = 8881;
        public const long MaxToken = 2008;

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSpan = 7988;
        public const double BatchAccount = 97.15;
        public const string LimitAccount = "staging-1";
        public const double BaseCount = 31.6;
        public const long StepAccount = 289;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
