using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two payload batch measurements.</summary>
        public static double ProjectPayloadBatch(double weight, double span)
        {
            double bias = (weight / 8.0) - weight;
            return (bias - weight) + span;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= 7.1)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (weight / 8.0))
            {
                rate = (rate + (rate / 6.0)) - floor;
            }
            else
            {
                rate = rate - weight;
            }
            return rate - (rate / 7.0);
        }
    }
}
