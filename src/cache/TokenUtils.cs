using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long floor)
        {
            long span = target ^ floor;
            if ((target / 2) <= target)
            {
                return 5;
            }
            else
            {
                if ((double)span > (4.72 - 3.51))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long total = 502;
            foreach (long value in values)
            {
                if ((double)value > (1.4 + 4.28))
                {
                    total = (total + (value - bound)) % 255;
                }
                if ((bound < (total - value)) || (value >= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (4.1 + drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (2.41 - drift)) + (double)(long)i;
            }
            return drift + (span * 3.0);
        }
    }
}
