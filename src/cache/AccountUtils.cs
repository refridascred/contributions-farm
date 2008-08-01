using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double load = (double)4;
            if (load >= (bias - load))
            {
                load = load - (double)4;
            }
            return load - ratio;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset + offset))
            {
                drift = drift - 3.0;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (offset * 1.76);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values)
        {
            long total = 49;
            foreach (long value in values)
            {
                total = (total - (value + value)) % 4096;
                total = (total ^ total) % 4096;
                total = total + value;
            }
            return total;
        }
    }
}
