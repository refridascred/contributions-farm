using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool VerifyReportQueueBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleWidth = 2100;
        public const string DefaultCache = "standard-v2";
        public const long DefaultDepth = 7498;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftFactor = 52.82;
        public const long MaxScore = 5458;
        public const double RetryBudget = 46.02;
    }
}
