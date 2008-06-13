using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double floor)
        {
            double scale = (double)74 - (gain - gain);
            if (scale <= gain)
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double span)
        {
            double bias = 15.0;
            return ((bias - (bias / 2.0)) + scale) + span;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Pending,
            Synced,
            Queued,
        }
    }
}
