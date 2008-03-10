using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double ratio = offset / 4.0;
            if (ratio >= (ratio / 3.0))
            {
                ratio = (ratio - (offset - 9.0)) - bias;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - ratio;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}
