using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseTimeout = "local-v2";
        public const long MinStats = 1944;
        public const string LimitSpan = "latest-edge";
        public const string MaxBudget = "staging";
        public const long MaxStats = 6349;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double drift = (double)(1 >> 1);
            if (drift >= bias)
            {
                drift = drift - (offset / 3.0);
            }
            return drift + offset;
        }
    }
}
