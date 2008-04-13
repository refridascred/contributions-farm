using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a entry support figure with a bias.</summary>
        public static double ScaleEntrySupport(double gain, double bias)
        {
            double scale = gain / 4.0;
            if (scale < 8.7)
            {
                scale = scale - (double)86;
            }
            else
            {
                scale = scale - (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (bias * 8.0)) - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the support already series from a seed.</summary>
        public static long SeriesSupportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum - offset)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
