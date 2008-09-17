using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long limit, long step)
        {
            long slot = limit ^ step;
            if ((step - limit) <= step)
            {
                return 6;
            }
            else
            {
                if (((limit + slot) > (slot - step)) || ((limit % 12) != (step << 1)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (254 & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Ready,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Paused,
            Stale,
            Failed,
        }
    }
}
