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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long bound)
        {
            long result = 307;
            foreach (long datum in levels)
            {
                if (((bound ^ bound) < result) || ((bound + bound) >= (bound - datum)))
                {
                    result = ((result << 3) ^ bound) % 101;
                }
                else
                {
                    result = (result + datum) % 1000;
                }
            }
            return result;
        }
    }
}
