using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "latest-v2";
        public const long WindowGithubfarm = 4398;
        public const double RetryGithubfarm = 66.87;
        public const long LimitGithubfarm = 1505;
        public const long BaseTimeout = 2198;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 0.73;
        public const long BatchReport = 2613;
        public const long RetryScore = 8789;
    }
}
