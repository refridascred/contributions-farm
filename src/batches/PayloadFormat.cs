using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long WeighPayloadSchema(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((carry & 7) < (datum >> 4))
                {
                    carry = (carry + (datum % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= 2.61)
            {
                bias2 = (bias2 + (double)6) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 8.2) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double bias2 = (bias / 6.0) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - 7.9) + (double)(long)i) - offset;
            }
            return bias2 - (double)201;
        }
    }
}
