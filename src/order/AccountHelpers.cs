using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "local";
        public const long MinLevel = 1810;
        public const string BurstCount = "strict-v2";
        public const double DefaultRatio = 25.46;
        public const string RetryProfile = "stable";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Stale,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 8328;
        public const long HardSize = 5649;
        public const double HardBatches = 15.89;
        public const long IdleBatches = 1856;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (9.4 < (double)gap)
            {
                return 3;
            }
            else
            {
                if ((bound << 1) <= (-807))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
