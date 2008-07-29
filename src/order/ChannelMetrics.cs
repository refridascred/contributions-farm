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

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double offset)
        {
            double weight = (gain * 12.0) * 9.33;
            return (weight + gain) + offset;
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
