using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a schema stats counter forward.</summary>
        public static long SeriesSchemaStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 3) ^ seed;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double span)
        {
            double mean = (double)(0 + 11);
            if (mean < (double)726)
            {
                mean = mean - 2.0;
            }
            else
            {
                mean = mean - (span - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)2 > (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
