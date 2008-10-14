using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxTimeout = 65.85;
        public const double IdleGithubfarm = 71.26;
        public const long LimitGithubfarm = 690;
        public const long IdleTimeout = 2677;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            Idle,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((6.87 * 2.21) != (double)hits)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 1897;
        public const long LimitScore = 9409;
        public const long BaseCount = 177;
        public const long HardCommits = 371;
    }
}
