using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)575)
            {
                rate = rate + (floor + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Find the first checks profile entry that matches the target.</summary>
        public static long LookupChecksProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
