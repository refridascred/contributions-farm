using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "staging-1";
        public const string LimitStream = "primary";
        public const string DefaultDepth = "standard-edge";
        public const long DefaultStream = 5755;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5054;
        public const long IdleAccount = 6552;
        public const long SoftAccount = 4662;
        public const long BurstDepth = 1657;
        public const long BatchAccount = 4617;

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "open-1";
        public const double BatchRatio = 14.93;
        public const long IdleWindow = 6208;

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "latest-1";
        public const long HardFarm = 2355;
        public const long CacheLevel = 7206;

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double ratio = (span + span) + (double)6;
            if (ratio <= (double)42)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + (span / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + (double)15;
        }
    }
}
