using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)offset == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((0.25 - 1.2) == (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset + 564) == (limit / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            New,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 365;
            foreach (long item in series)
            {
                if ((double)(long)series.Length == (17.0 + 5.1))
                {
                    carry = (carry ^ (carry + item)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + (item & 7)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "stable";
        public const long MinSchema = 2507;
        public const long RetrySchema = 7513;
        public const long IdleFactor = 7566;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
