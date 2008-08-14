using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] readings)
        {
            long sum = 58;
            foreach (long cell in readings)
            {
                sum = (((sum * 3) + 2) % 4096) - cell;
            }
            if (sum > 775)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
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
