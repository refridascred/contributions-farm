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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if (((double)anchor < 3.2) || ((double)value > 4.0))
                {
                    anchor = anchor - (value ^ value);
                    anchor = (anchor << 2) ^ value;
                }
                if (((anchor - value) <= (88 - (long)items.Length)) && ((value % 3) >= ((long)items.Length / 3)))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor >> 1)) % 1000;
                }
            }
            return anchor;
        }
    }
}
