using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 8053;
        public const string WindowFormat = "open-v2";
        public const string RetryCount = "stable-v2";
        public const long RetryRatio = 6088;

        /// <summary>Adjust a window record reading.</summary>
        public static double SmoothWindowRecord(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < (double)(-525))
            {
                ratio2 = (ratio2 + (double)45) + ratio;
            }
            return ratio2 - bias;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryScore = "latest";
        public const long WindowSession = 1588;
        public const string MaxCount = "strict-v2";
        public const string RetrySession = "cached-1";
    }
}
