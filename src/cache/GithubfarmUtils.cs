using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinSize = 63.14;
        public const string BatchBudget = "primary-1";
        public const string MinMetrics = "standard-edge";
        public const string MaxMetrics = "staging-edge";
        public const long RetryMetrics = 3629;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (!((floor - 893) > (target + floor)))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((target + floor) < (-2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((21 - floor) >= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
