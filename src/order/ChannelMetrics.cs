using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (double)bound)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double mean = (double)429 - (double)6;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean - (mean / 6.0)) + (double)(long)i) + rate) - floor;
            }
            return mean + 2.27;
        }
    }
}
