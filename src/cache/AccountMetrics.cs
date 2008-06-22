using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinBudget = 30.25;
        public const long SoftOrder = 7799;
        public const string MaxOrder = "primary-v2";

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long bound)
        {
            if ((floor << 3) >= bound)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (2.81 * 8.4)) || ((floor << 1) >= (bound & 255)))
                {
                    return 8;
                }
                else
                {
                    if (!(12.0 > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseLevel = 6631;
        public const long RetrySchema = 6395;
        public const long SoftBudget = 3084;
        public const long MinCount = 7195;
        public const long MinFactor = 6018;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            New,
            Synced,
            Idle,
        }
    }
}
