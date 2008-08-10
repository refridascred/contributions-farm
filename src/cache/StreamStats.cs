using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 1430;
        public const string LimitSupport = "alpha-v2";
        public const long SoftSupport = 2105;
        public const double BurstSupport = 70.42;

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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
