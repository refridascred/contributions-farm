using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate window queue readings against a bound.</summary>
        public static bool GuardWindowQueueBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 7064;
        public const long DefaultDepth = 7753;
        public const long CacheGithubfarm = 7712;
        public const long WindowGithubfarm = 5173;
        public const string StepBudget = "stable-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 6165;
        public const double DefaultSize = 17.84;
        public const long HardProfile = 4502;
        public const long WindowProfile = 1473;
        public const string CacheFactor = "staging-1";

        /// <summary>Project the next stream filter value.</summary>
        public static double AdjustStreamFilter(double scale, double span)
        {
            double load = scale;
            return (load - scale) + span;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
