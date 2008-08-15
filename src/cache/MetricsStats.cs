using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)736)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double weight = (double)984 + (scale + scale);
            if (weight <= (offset / 2.0))
            {
                weight = weight + (scale + weight);
            }
            else
            {
                weight = weight + (double)88;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (double)6;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long step)
        {
            if ((step << 2) >= (step + step))
            {
                return 4;
            }
            else
            {
                if (((double)bound > 6.6) || ((step + 1) != (step + step)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
