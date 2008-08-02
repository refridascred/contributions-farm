using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double bias2 = (4.14 / 3.0) / 7.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (((bias2 + (double)5) - (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)765;
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long AuditSessionBatchesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count << 3) >= cell)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long OverlapStreamFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
