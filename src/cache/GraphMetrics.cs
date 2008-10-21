using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 3942;
        public const long LimitEditor = 6947;
        public const string StepRatio = "stable-edge";
        public const long MinEditor = 3349;
        public const long BaseEditor = 7916;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                carry = ((carry << 2) ^ (carry & 63)) ^ sample;
            }
            return carry % 97;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            Done,
            Queued,
            Retry,
        }
    }
}
