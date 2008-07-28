using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = (double)(269 & 127);
            return (rate2 - (floor + floor)) + rate;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "stable-1";
        public const long HardRatio = 8406;
        public const long LimitWidth = 4631;

        /// <summary>Validate already commits readings against a bound.</summary>
        public static bool GuardAlreadyCommitsBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
