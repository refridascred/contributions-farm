using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 5) <= (1 << 2))
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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < (target - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleTimeout = 6019;
        public const string StepWidth = "primary";
        public const long MinGithubfarm = 2955;
        public const long CacheGithubfarm = 7595;
        public const long WindowGithubfarm = 5059;
    }
}
