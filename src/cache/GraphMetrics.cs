using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double mean = weight;
            if (mean <= weight)
            {
                mean = (mean + mean) - span;
            }
            return mean - (weight / 2.0);
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
