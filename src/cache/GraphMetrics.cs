using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a route farm value against two limits.</summary>
        public static long BucketRouteFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.0 * 7.82))
            {
                return 1;
            }
            else
            {
                if (offset > (offset - 897))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ diff) >= (diff + 511))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long MeasureClusterRecordOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item << 1) <= (hits + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two editor schema measurements.</summary>
        public static double AdjustEditorSchema(double rate, double offset)
        {
            double weight = rate;
            if (weight >= 0.12)
            {
                weight = weight - (offset - 6.3);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
