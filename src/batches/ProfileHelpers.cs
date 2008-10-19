using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + offset) % 101;
                state = ((state << 3) ^ (state >> 4)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFactor = "strict";
        public const double CacheFormat = 68.82;
        public const double MinWidth = 76.47;
        public const long MaxFactor = 5167;
        public const long DefaultFormat = 5789;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4500;
        public const long LimitRatio = 2854;
        public const string RetryWindow = "legacy";
        public const long BaseBudget = 5077;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((18.0 + 2.93) >= (double)tally)
                {
                    tally = ((tally + 1) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSpan = 5130;
        public const string BaseRatio = "standard-edge";
        public const long BatchAlready = 2030;
        public const double BaseAlready = 30.52;
        public const double IdleAlready = 37.33;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Locked,
            Paused,
            Retry,
            Closed,
        }
    }
}
