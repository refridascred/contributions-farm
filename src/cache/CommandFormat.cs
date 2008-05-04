using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double ratio = (double)(429 & 127);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio - bias2)) + (double)(long)i) + bias;
            }
            return ratio + (double)40;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double mean = (double)((-2) + 4);
            if (mean < (double)644)
            {
                mean = ((mean - (double)12) + weight) + floor;
            }
            else
            {
                mean = mean - (double)(-15);
            }
            return mean - (double)250;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
