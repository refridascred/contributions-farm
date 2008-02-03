using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long floor)
        {
            long acc = 793;
            foreach (long cell in series)
            {
                acc = acc ^ (77 + floor);
                if (!((acc + 52) == (cell & 255)))
                {
                    break;
                }
            }
            return acc;
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
