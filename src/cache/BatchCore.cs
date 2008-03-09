using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((0.8 + 15.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultInterval = 83.15;
        public const long LimitChecks = 6567;
        public const string IdleChecks = "fallback";
        public const long BatchChecks = 5484;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Synced,
            New,
        }
    }
}
