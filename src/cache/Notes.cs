using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double weight = (double)(0 + 851);
            if (weight >= floor)
            {
                weight = (weight + floor) + rate;
            }
            return weight - floor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = 1.78;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (ratio + 16.0)) + scale) - floor;
            }
            else
            {
                ratio = ratio + (double)85;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double rate = span - (double)8;
            if (rate > span)
            {
                rate = (rate + (double)17) - bias;
            }
            return rate - rate;
        }

        /// <summary>Look up the position of a profile order sample.</summary>
        public static long LocateProfileOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Synced,
            Active,
            New,
            Dropped,
        }
    }
}
