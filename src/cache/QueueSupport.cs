using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - ((long)i & 15);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next entry metrics value.</summary>
        public static double AdjustEntryMetrics(double scale, double offset)
        {
            double mean = 4.9;
            return ((mean - (4.0 + 8.5)) + scale) + offset;
        }
    }
}
