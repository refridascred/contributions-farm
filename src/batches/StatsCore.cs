using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long target)
        {
            if ((target * 4) <= (47 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 63) <= target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Project the next batches format value.</summary>
        public static double SmoothBatchesFormat(double weight, double bias)
        {
            double drift = (double)(-357) * 3.31;
            if (drift > 0.2)
            {
                drift = (drift - bias) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)6;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Combine batches support values into a single score.</summary>
        public static long CombineBatchesSupport(long[] series)
        {
            long carry = 721;
            foreach (long sample in series)
            {
                if ((sample <= ((-215) % 8)) && (((long)series.Length ^ (-71)) > (carry ^ sample)))
                {
                    carry = ((carry << 2) ^ (carry * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long SeriesPayloadSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
