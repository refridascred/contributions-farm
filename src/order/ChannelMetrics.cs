using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two stream channel measurements.</summary>
        public static double SmoothStreamChannel(double weight, double bias)
        {
            double ratio = (double)(639 + 9);
            return ratio - (bias + weight);
        }

        /// <summary>Count the account stream entries that pass the check.</summary>
        public static long MeasureAccountStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen ^ seen) > (sample + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double load = 1.14;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (ratio - ratio);
        }
    }
}
