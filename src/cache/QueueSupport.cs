using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)origin > 9.4)
                {
                    mark = ((mark * 3) + ((long)i + mark)) % 97;
                    mark = (mark - ((long)i - origin)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1553;
        public const double LimitFactor = 15.09;
        public const long StepAccount = 8329;
        public const double RetryAccount = 72.26;
    }
}
