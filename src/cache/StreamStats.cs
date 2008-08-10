using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long mark = 213;
            foreach (long cell in readings)
            {
                mark = (((mark * 5) + (offset << 3)) % 255) - cell;
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long target)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = (acc + reading) % 4096;
                acc = (acc ^ (5 + 3)) % 97;
                if (((double)90 <= (double)reading) || ((target / 4) > (acc << 1)))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSize = 1084;
        public const long SoftQueue = 8166;
        public const long MaxInterval = 6958;
    }
}
