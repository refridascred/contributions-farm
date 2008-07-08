using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double floor)
        {
            double gain = (9.6 / 6.0) * 20.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - floor) + (double)(long)i) - bias;
            }
            return gain - (gain / 2.0);
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
