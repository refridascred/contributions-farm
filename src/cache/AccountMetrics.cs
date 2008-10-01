using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 6548;
        public const long BatchContributi = 8657;
        public const long MaxSpan = 6895;
        public const string BurstContributi = "alpha-v2";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Queued,
            New,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.48;
        public const string SoftStats = "staging-v2";
        public const long LimitStats = 8047;
        public const long BatchSpan = 35;
        public const long WindowStats = 2961;

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "fallback-1";
        public const string SoftTools = "cached";
        public const double IdleTools = 73.25;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
