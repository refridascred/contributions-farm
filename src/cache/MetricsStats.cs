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

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((state - state) <= (-8))
                {
                    state = ((state * 2) + state) % 4096;
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
