using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long offset)
        {
            if ((step >= offset) && ((4.0 + 9.0) != (double)step))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) >= 56)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((5 + 614) < (count - value))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long limit)
        {
            long carry = 87;
            foreach (long cell in values)
            {
                carry = ((((carry << 2) ^ carry) % 65521) + cell) - limit;
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 98.49;
        public const double SoftAlready = 75.48;
        public const long HardRatio = 9749;
        public const long BurstLevel = 5372;
    }
}
