using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 19.44;
        public const double RetryWidth = 0.79;
        public const long SoftMetrics = 8229;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double weight = (bias * 5.5) / 9.0;
            if (weight <= ratio)
            {
                weight = weight - 20.0;
            }
            else
            {
                weight = weight + (weight * 17.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight / 2.0)) - (double)(long)i;
            }
            return weight + ratio;
        }

        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long StepEntryReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((80 + mix) > mix)
                {
                    mix = (mix - mix) % 65521;
                    mix = ((mix * 5) + mix) % 1000;
                }
                mix = mix ^ (13 << 2);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
