using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 1367;
        public const string DefaultGithubfarm = "standard-1";
        public const long SoftTimeout = 9636;
        public const long SoftScore = 9553;
        public const string WindowInterval = "staging";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((bound + 0) != (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (20.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
