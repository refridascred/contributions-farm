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

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 3331;
        public const double IdleBudget = 54.99;
        public const double RetryFormat = 24.36;
        public const long BaseBudget = 5619;
        public const long WindowFormat = 4445;

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
