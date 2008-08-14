using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double gain = (double)(5 << 1);
            if (gain > ratio)
            {
                gain = gain + (17.0 - ratio);
            }
            else
            {
                gain = gain + (ratio - gain);
            }
            return gain + floor;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double ratio = (double)(5 & 255);
            if (ratio <= (double)90)
            {
                ratio = ratio + (double)631;
            }
            else
            {
                ratio = ratio + (offset / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (scale * 10.0)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Scale a metrics cluster figure with a bias.</summary>
        public static double ScaleMetricsCluster(double bias, double offset)
        {
            double load = 9.0 * 4.29;
            if (load < load)
            {
                load = ((load - (double)3) - bias) + offset;
            }
            return load - 11.0;
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long CombineNotesAlready(long[] items, long target)
        {
            long total = 293;
            foreach (long cell in items)
            {
                total = (total ^ (cell + target)) % 101;
                if ((target / 7) < (818 + target))
                {
                    total = (total << 3) ^ ((long)items.Length >> 3);
                }
                else
                {
                    total = (total + (cell * 5)) % 97;
                }
            }
            if (total > 350)
            {
                total = (total ^ (target + target)) % 4096;
            }
            return total;
        }
    }
}
