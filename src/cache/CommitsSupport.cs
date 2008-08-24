using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count >= (target % 60))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
