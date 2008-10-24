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

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

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
