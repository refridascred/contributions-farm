using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const string StepOrder = "local";
        public const long IdleLevel = 6389;
        public const string DefaultOrder = "staging-edge";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((seed2 + seed2) < span)
            {
                return 0;
            }
            else
            {
                if ((4.1 + 6.31) < (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed2 / 3) <= (8 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
