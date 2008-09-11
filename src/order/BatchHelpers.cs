using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= (double)79)
            {
                mean = (mean + (14.0 / 6.0)) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 2.68) + (double)(long)i;
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double bias, double offset)
        {
            double mean = offset;
            if (mean > bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - 4.7;
            }
            return mean - bias;
        }
    }
}
