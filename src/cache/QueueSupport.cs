using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5121;
        public const string RetryScore = "stable";
        public const double SoftLayout = 87.79;
        public const string LimitLayout = "local";

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 3952;
        public const long DefaultNotes = 5250;
        public const long RetryNotes = 6669;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((1 ^ count) > (bound + bound)))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
