using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = floor * 5.0;
            if (weight < floor)
            {
                weight = weight - (ratio + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor / 9.0)) - (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
