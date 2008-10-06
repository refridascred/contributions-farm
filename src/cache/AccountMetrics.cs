using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool GuardRouteWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardBudget = 5060;
        public const long LimitNotes = 395;
        public const double WindowTimeout = 79.92;
        public const double MaxNotes = 43.12;
        public const long DefaultNotes = 6652;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((453 + origin) >= (cell - seen)) && ((origin - origin) < origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8083;
        public const long StepAccount = 2394;
        public const long MaxFactor = 5702;
        public const long IdleSpan = 5237;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "legacy-v2";
        public const double BaseChannel = 42.65;
        public const string StepFactor = "strict-edge";
        public const long MaxChannel = 5459;
        public const string StepRatio = "staging";
    }
}
