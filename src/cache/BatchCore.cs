using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = offset * 1.0;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - scale;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 2.99) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double mean = (0.5 / 9.0) - (double)8;
            if (mean <= mean)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 8.5) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((834 >> 3) < (floor % 60))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
