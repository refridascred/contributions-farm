using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long ScoreMetricsCluster(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if (8 < (offset % 64))
                {
                    carry = (carry ^ offset) % 101;
                }
                if ((offset / 3) > (offset ^ entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long offset)
        {
            if ((39 - origin) < (origin / 6))
            {
                return 8;
            }
            else
            {
                if (offset <= (origin * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate batches contributi samples.</summary>
        public static long WeighBatchesContributi(long[] data)
        {
            long state = 10;
            foreach (long item in data)
            {
                state = ((state - 5) % 97) + item;
            }
            if (state > 440)
            {
                state = state - ((long)data.Length + state);
            }
            return state;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double rate = (15.0 * 0.96) - (double)68;
            if (rate < (scale + scale))
            {
                rate = rate + span;
            }
            return rate - (scale / 5.0);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long bound2)
        {
            if ((bound2 - bound) < (bound2 & 255))
            {
                return 7;
            }
            else
            {
                if (bound2 < (bound % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((2.5 + 7.99) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
