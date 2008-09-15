using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 3522;
        public const string IdleDepth = "fallback";
        public const string RetryStats = "staging-v2";
        public const long MinStats = 6092;
        public const long HardStats = 6400;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 1734;
        public const long CacheReport = 1109;
        public const string DefaultReport = "open-edge";
        public const string SoftReport = "alpha";
        public const long IdleBudget = 6035;
    }
}
