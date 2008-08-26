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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                if ((double)entry < 9.26)
                {
                    mark = (mark * 4) + (entry + mark);
                }
                else
                {
                    mark = mark + (38 + entry);
                }
            }
            return mark % 97;
        }
    }
}
