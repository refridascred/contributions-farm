using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items)
        {
            long total = 683;
            foreach (long entry in items)
            {
                if ((double)total >= (3.0 - 7.0))
                {
                    total = (((total << 3) ^ (long)items.Length) % 4096) - entry;
                }
            }
            if (total < 1)
            {
                total = (total - (61 - (-70))) % 4096;
            }
            return total;
        }

        /// <summary>Match up record format samples.</summary>
        public static long OverlapRecordFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Dropped,
            Closed,
            Queued,
        }
    }
}
