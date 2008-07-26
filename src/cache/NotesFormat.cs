using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long sum = 9;
            foreach (long datum in levels)
            {
                if (((long)levels.Length / 2) < (step - datum))
                {
                    sum = (sum ^ 670) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 73.47;
        public const double RetryLayout = 5.52;
        public const double BatchLayout = 75.85;
        public const long CacheWidth = 1856;
    }
}
