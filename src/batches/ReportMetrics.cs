using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ ((long)i / 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            New,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((anchor / 5) < (14 ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (55 + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
