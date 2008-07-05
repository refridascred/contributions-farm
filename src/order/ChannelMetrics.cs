using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if (limit > ((long)i % 24))
                {
                    anchor = (anchor + ((long)i >> 5)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double load = (scale / 7.0) * 3.55;
            if (load < (scale / 8.0))
            {
                load = (load - (scale / 4.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - 5.7;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
