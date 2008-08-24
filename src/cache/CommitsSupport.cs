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

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((590 + 27) >= (floor + 28))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
