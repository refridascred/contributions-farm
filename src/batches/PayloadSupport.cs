using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings, long target)
        {
            long mix = 310;
            foreach (long datum in readings)
            {
                mix = (mix + (datum - target)) % 101;
                mix = mix + ((-55) / 5);
                if ((57 / 3) >= target)
                {
                    mix = (mix - (target >> 3)) % 97;
                }
                else
                {
                    mix = (mix ^ target) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double rate = floor;
            if (rate < (rate * 7.1))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate - 0.2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long next = offset + limit;
            if ((limit * 3) >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit - (-17)) <= (next - limit))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
