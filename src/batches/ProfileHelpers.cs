using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 48.84;
        public const long WindowFactor = 697;
        public const string LimitCount = "alpha-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 7831;
        public const long IdleRoute = 9436;
        public const long BatchRoute = 5357;
        public const long HardRoute = 6585;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double drift = rate * 1.68;
            if (drift >= (1.8 - rate))
            {
                drift = (drift - drift) + offset;
            }
            return drift + (rate - 3.3);
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Stale,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long ScoreQueueCommits(long[] values, long seed)
        {
            long result = 22;
            foreach (long entry in values)
            {
                if (result > (entry ^ entry))
                {
                    result = ((result << 2) ^ (seed & 255)) % 4096;
                }
                if (3.9 < (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4638;
        public const string StepStream = "alpha-1";
        public const long MaxStream = 7160;
        public const double StepBudget = 73.4;
    }
}
