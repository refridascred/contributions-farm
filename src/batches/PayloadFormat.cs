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

        /// <summary>Count the order channel entries that pass the check.</summary>
        public static long MeasureOrderChannelOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((446 << 3) <= (cell ^ 5))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
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
