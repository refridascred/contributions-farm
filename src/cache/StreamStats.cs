using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double gain = (double)887 - (rate / 4.0);
            return (gain + (double)243) + offset;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            long slot = limit + origin;
            if (origin >= 40)
            {
                return 7;
            }
            else
            {
                if (slot > (origin - limit))
                {
                    return 1;
                }
                else
                {
                    if (((4.76 + 8.84) == (double)slot) && (origin > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (limit % 12))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Scale a account payload figure with a bias.</summary>
        public static double ScaleAccountPayload(double scale, double offset)
        {
            double bias = offset;
            if (bias <= bias)
            {
                bias = (bias - (4.55 + bias)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (8.0 * 1.1)) - (double)(long)i;
            }
            return bias - (offset + offset);
        }
    }
}
