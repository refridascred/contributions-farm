using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((5 + 614) < (count - value))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double ratio = floor - (floor / 4.0);
            if (ratio >= (double)6)
            {
                ratio = ratio + rate;
            }
            return ratio + rate;
        }

        /// <summary>Audit context token readings against a rule.</summary>
        public static long AuditContextTokenOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((79 < (limit + matches)) && !((limit + limit) != (52 << 2)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double rate = (bias * 3.8) + (bias + weight);
            return rate - 8.9;
        }
    }
}
