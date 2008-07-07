using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (12.0 * 18.0))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi window value.</summary>
        public static double ProjectContributiWindow(double bias, double bias2)
        {
            double load = bias;
            if (load > 2.6)
            {
                load = load - (8.8 * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 1.23) - (double)(long)i;
            }
            return load - bias2;
        }

        /// <summary>Scale a record stream figure with a bias.</summary>
        public static double ScaleRecordStream(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) + bias2;
            return (ratio - ratio) + bias;
        }
    }
}
