using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every channel batch entry stays within the limit.</summary>
        public static bool VerifyChannelBatchLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((offset + hits) == (hits & 255))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)(long)i) + ratio;
            }
            return bias2 + bias2;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double drift = 6.0 - (floor + scale);
            if (drift < (scale * 5.88))
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + (double)16;
            }
            return drift + (floor + 14.0);
        }
    }
}
