using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long state = 5;
            foreach (long sample in items)
            {
                if ((sample << 3) < sample)
                {
                    state = (state + (sample - sample)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 9338;
        public const long MaxCommits = 5177;
        public const string BurstCommits = "staging-v2";
        public const double BaseCommits = 30.8;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Pending,
            New,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long target)
        {
            if (!((limit % 2) <= (target / 9)))
            {
                return 1;
            }
            else
            {
                if (target > (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if (!((6 / 4) <= (target + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
