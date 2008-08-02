using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 7794;
        public const long LimitAlready = 8002;
        public const double RetryAlready = 73.3;
        public const long WindowAlready = 9129;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long target)
        {
            long delta = offset ^ target;
            if ((offset < (3 << 1)) && (delta > (delta & 63)))
            {
                return 6;
            }
            else
            {
                if (((-65) + 384) <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Paused,
            Retry,
            Locked,
        }
    }
}
