using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order record reading by value.</summary>
        public static long FindOrderRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double load = (floor / 3.0) / 6.0;
            if (load >= (load * 1.89))
            {
                load = load + (1.73 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (8.36 * 6.32)) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
