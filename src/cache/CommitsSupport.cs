using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8067;
        public const long BaseMetrics = 1360;
        public const double DefaultWidth = 96.13;
        public const long LimitMetrics = 3618;
        public const long WindowSize = 3457;

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Rank token context input into a small class.</summary>
        public static long BucketTokenContext(long limit, long origin)
        {
            if ((origin >> 3) == (limit ^ origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (9.5 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((208 - limit) == (origin - 827))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
