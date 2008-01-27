using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate notes token samples.</summary>
        public static long DigestNotesToken(long[] items, long bound)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = ((mark + (reading << 1)) % 4096) + bound;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 69.65;
        public const double StepGithubfarm = 30.6;
        public const string LimitGithubfarm = "stable-edge";
        public const long CacheGithubfarm = 330;
    }
}
