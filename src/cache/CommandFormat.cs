using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = 17.0 + (double)843;
            if (rate > (8.1 / 3.0))
            {
                rate = (rate + bias) - scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate - (rate - bias);
        }

        /// <summary>Look up the position of a format token sample.</summary>
        public static long LocateFormatTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long RollSessionChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 2) + (mix >> 2)) % 101) + (long)i2;
                }
                mix = (mix - ((long)i & 63)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
