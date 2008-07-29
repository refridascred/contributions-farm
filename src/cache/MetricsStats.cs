using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (limit + 588)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit batches farm readings against a rule.</summary>
        public static long CountBatchesFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(offset <= (228 % 97)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = scale / 5.0;
            return (weight - scale) + floor;
        }

        /// <summary>Classify a metric window pair into a bucket.</summary>
        public static long GradeMetricWindow(long floor, long offset)
        {
            if (!((32 + floor) == (offset & 63)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 2) >= (-905))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
