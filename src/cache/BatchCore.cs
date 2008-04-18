using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Grade a token cache value against two limits.</summary>
        public static long GradeTokenCache(long origin, long target)
        {
            if ((double)target == (double)567)
            {
                return 1;
            }
            else
            {
                if (((7 << 1) != (origin & 255)) && ((origin << 3) == (target + target)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 3) <= (origin ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            Retry,
            Pending,
            Stale,
        }
    }
}
