using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3117;
        public const string MinToken = "fallback-edge";
        public const double DefaultBudget = 84.49;
        public const string BurstScore = "open-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a metric githubfarm value against two limits.</summary>
        public static long GradeMetricGithubfarm(long offset, long offset2)
        {
            if ((offset2 - 69) <= offset)
            {
                return 7;
            }
            else
            {
                if (((-896) & 1) > offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ 0) <= (offset ^ 820))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
