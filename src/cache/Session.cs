using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools token measurements.</summary>
        public static double ScaleToolsToken(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 3.37) - (double)(long)i) - floor;
            }
            return load - (load * 5.44);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + ((long)i - floor)) % 65521) - (long)i2;
                }
                bool found = (3.9 - 14.0) <= (double)floor;
                if (!found)
                {
                    found = ((12.0 * 4.8) >= (double)mark) || ((double)floor <= (4.48 / 5.0));
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate channel stream readings against a bound.</summary>
        public static bool GuardChannelStreamLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double weight = (double)(2 + 2);
            if (weight >= gain)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain + 0.3);
        }
    }
}
