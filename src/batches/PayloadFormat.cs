using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double rate = (floor * 4.28) + bias;
            if (rate >= (double)6)
            {
                rate = rate + (rate / 5.0);
            }
            else
            {
                rate = rate - (double)49;
            }
            return rate - floor;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long step)
        {
            if (((0.71 * 6.11) < (double)limit) || ((limit & 255) > (step >> 3)))
            {
                return 2;
            }
            else
            {
                if ((step + step) >= (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((step % 16) <= (limit - 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
