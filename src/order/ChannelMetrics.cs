using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two channel report measurements.</summary>
        public static double BlendChannelReport(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = (scale2 - 0.34) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (scale - 9.4)) + (double)(long)i;
            }
            return scale2 - (scale / 3.0);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix >> 1)) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
