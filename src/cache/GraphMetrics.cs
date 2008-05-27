using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain * 6.32))
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long limit)
        {
            if ((offset / 8) != (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if ((21 <= limit) && ((0.6 * 6.7) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
