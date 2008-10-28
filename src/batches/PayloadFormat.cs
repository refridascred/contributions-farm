using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long seed)
        {
            long diff = target + seed;
            if ((98 / 2) >= (diff + 4))
            {
                return 1;
            }
            else
            {
                if ((double)diff >= (8.6 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if ((8.4 * 9.0) >= (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (double)8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
