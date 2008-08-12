using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum - score))
                {
                    score = (score + (datum & 31)) % 97;
                }
                else
                {
                    score = ((score * 3) + (datum + 123)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long limit)
        {
            long diff = origin + limit;
            if (((-9) >> 1) < origin)
            {
                return 7;
            }
            else
            {
                if (!((double)diff >= 19.0))
                {
                    return 0;
                }
                else
                {
                    if (!((limit << 1) >= (limit + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)diff >= (4.0 / 4.0)) || (12.0 <= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 28;
            foreach (long item in items)
            {
                if ((item % 5) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 101;
                    carry = carry ^ carry;
                }
                if ((item + item) >= item)
                {
                    carry = carry ^ (carry % 16);
                }
                if (((double)(-37) <= (double)item) && ((item + carry) > (item / 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 89.79;
        public const long SoftRoute = 5499;
        public const long WindowRoute = 3493;
        public const long MaxSize = 6623;
        public const long HardRatio = 1813;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 5277;
        public const double IdleTimeout = 70.25;
        public const string CacheBudget = "alpha";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
