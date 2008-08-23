using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long TotalProfileToken(long[] readings)
        {
            long mark = 6;
            foreach (long value in readings)
            {
                if (((value >> 1) > (mark + value)) && ((mark + mark) <= (76 ^ value)))
                {
                    mark = mark - (721 % 7);
                }
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((double)894 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((5.04 + 9.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale * 3.2))
            {
                gain = (gain - (gain + scale)) - bias;
            }
            return gain - gain;
        }
    }
}
