using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a checks entry reading.</summary>
        public static double AdjustChecksEntry(double ratio, double span)
        {
            double bias = span;
            if (bias <= (double)(-62))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + 0.1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long step2)
        {
            if ((step2 >> 1) >= step2)
            {
                return 5;
            }
            else
            {
                if ((9.56 * 2.6) < (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command format values into a single score.</summary>
        public static long TotalCommandFormat(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ (reading << 1)) % 65521;
            }
            return anchor;
        }
    }
}
