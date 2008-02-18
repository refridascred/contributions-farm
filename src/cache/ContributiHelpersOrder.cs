using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double mean = (double)(72 + 26);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)66) + (double)(long)i) - bias) - offset;
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Count the filter metric entries that pass the check.</summary>
        public static long AuditFilterMetricGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ seen) > (item << 1))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Match up tools counter samples.</summary>
        public static long OverlapToolsCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
