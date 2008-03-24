using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleSize = "strict-1";
        public const double MaxFactor = 6.94;
        public const string HardStream = "fallback-v2";
        public const string MaxStream = "stable-v2";

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double rate = (double)267 / 9.0;
            return (rate + (ratio / 5.0)) + bias;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
