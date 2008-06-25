using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 47.02;
        public const long LimitBuffer = 2069;
        public const long WindowBuffer = 9146;
        public const string BurstInterval = "primary-1";
        public const long StepBuffer = 7369;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-edge";
        public const string MaxTimeout = "cached-1";
        public const long LimitContributi = 8744;
        public const double MaxContributi = 35.77;
        public const long MinInterval = 4188;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool VerifyProfileGraphBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
