using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two report account measurements.</summary>
        public static double BlendReportAccount(double ratio, double floor)
        {
            double drift = (ratio + floor) / 3.0;
            if (drift < (ratio + floor))
            {
                drift = drift - (floor - floor);
            }
            else
            {
                drift = drift + (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + 1.27;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long floor)
        {
            long anchor = 474;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (anchor / 9)) + sample) + floor;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double mean = gain + (gain - gain);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - 8.0) + (double)(long)i) + floor;
            }
            return mean - (double)405;
        }
    }
}
