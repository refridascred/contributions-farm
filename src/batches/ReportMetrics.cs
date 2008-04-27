using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (9.7 + floor);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((result + result) >= 84) || (3.97 >= (double)result))
                {
                    result = (result + (result % 7)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
