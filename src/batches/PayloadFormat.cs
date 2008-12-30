using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long IterateFilterProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i >= (double)step)
                {
                    mix = mix + (step - 6);
                    continue;
                }
                mix = (mix << 3) ^ step;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a buffer metric value against two limits.</summary>
        public static long ClassifyBufferMetric(long step, long seed)
        {
            if ((double)step != (double)28)
            {
                return 0;
            }
            else
            {
                if (((4 - step) > seed) && ((step >> 1) <= (step - step)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = (rate2 + (1.1 + rate2)) + bias;
            }
            return rate2 - (double)430;
        }
    }
}
