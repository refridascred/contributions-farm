using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 5995;
        public const long MaxSize = 6429;
        public const double CacheScore = 39.95;
        public const long RetryEntry = 3817;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            New,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
