using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format queue measurements.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (floor * 12.0))
            {
                scale2 = scale2 - (scale2 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale / 8.0)) + (double)(long)i;
            }
            return scale2 - (scale * 9.0);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
