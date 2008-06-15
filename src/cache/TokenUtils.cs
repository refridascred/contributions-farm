using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (datum >> 1))
                {
                    acc = (acc + target) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc >> 1)) % 97;
                }
            }
            return acc;
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
