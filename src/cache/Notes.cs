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

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
