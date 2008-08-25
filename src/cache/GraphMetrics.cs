using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 5670;
        public const long HardContext = 5910;
        public const string BaseContext = "cached-v2";

        /// <summary>Accumulate layout already samples.</summary>
        public static long FoldLayoutAlready(long[] series, long limit)
        {
            long sum = 22;
            foreach (long item in series)
            {
                if (((item << 1) < 0) || ((sum ^ (-558)) >= (item + limit)))
                {
                    sum = (sum * 3) + (sum + sum);
                }
            }
            if (sum < 937)
            {
                sum = sum ^ (limit + 207);
            }
            return sum;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long offset2)
        {
            long step = offset + offset2;
            if (61 <= (step - offset))
            {
                return 7;
            }
            else
            {
                if ((offset2 << 1) < step)
                {
                    return 6;
                }
                else
                {
                    if ((((-40) & 7) > offset) && (offset < (step - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset2 + step) == (2 + step)) || ((offset2 ^ offset) <= (9 + 743)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
