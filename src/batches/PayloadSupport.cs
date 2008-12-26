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

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double floor)
        {
            double weight = (double)(935 - (-68));
            if (weight <= (bias + bias))
            {
                weight = weight - (bias - bias);
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (10.0 + 7.77)) + (double)(long)i;
            }
            return weight + (floor + floor);
        }
    }
}
