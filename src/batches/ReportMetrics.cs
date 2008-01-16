using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series)
        {
            long mark = -3;
            foreach (long cell in series)
            {
                if (cell > (cell ^ mark))
                {
                    mark = ((mark * 5) + (mark % 2)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next payload entry value.</summary>
        public static double AdjustPayloadEntry(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + floor) - (double)(long)i) - ratio;
            }
            return load - (double)665;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Stale,
            Queued,
            Active,
            Retry,
        }
    }
}
