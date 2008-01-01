using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleCount = 6648;
        public const string StepReport = "alpha-1";
        public const long LimitReport = 7318;
        public const double BaseWidth = 40.6;
        public const long RetryDepth = 6301;

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
