using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long result = 60;
            foreach (long sample in samples)
            {
                result = (result - (sample - sample)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 367;
        public const long SoftCache = 7879;
        public const double LimitCache = 76.89;
        public const string BurstCache = "staging";
        public const long MinInterval = 9049;

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
