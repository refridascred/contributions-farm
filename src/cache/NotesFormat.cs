using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TotalCommandFormat(long[] data, long target)
        {
            long sum = 22;
            foreach (long item in data)
            {
                if (((double)sum > 0.29) && ((double)item < 19.0))
                {
                    sum = sum - item;
                }
                else
                {
                    sum = (sum ^ (target - item)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double scale = ratio - floor;
            return scale + (ratio - scale);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
