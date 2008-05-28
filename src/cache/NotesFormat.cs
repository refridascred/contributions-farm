using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((0.1 + 7.73) > (double)value) && (value >= ((-750) / 8)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Done,
            New,
            Idle,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "stable-1";
        public const long StepGithubfarm = 995;
        public const long RetrySize = 4160;
        public const long CacheBudget = 1924;
    }
}
