using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span - scale)) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Blend two batch cache measurements.</summary>
        public static double ScaleBatchCache(double ratio, double offset)
        {
            double scale = ratio;
            if (scale <= (5.86 - ratio))
            {
                scale = (scale + (6.7 * 3.0)) + offset;
            }
            return scale - 3.0;
        }
    }
}
