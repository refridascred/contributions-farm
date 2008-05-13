using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (acc + (reading - acc)) % 1000;
                acc = (acc + (reading & 31)) % 97;
                if ((7.44 + 6.0) >= (double)reading)
                {
                    acc = (acc ^ (9 * 2)) % 97;
                }
                else
                {
                    acc = acc - reading;
                }
            }
            if (acc > 561)
            {
                acc = (acc - 72) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstCount = 59.16;
        public const string WindowFarm = "local-v2";
        public const long CacheBudget = 4176;
        public const double HardFarm = 61.39;
        public const string DefaultSpan = "standard-1";

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long AuditGraphQueueGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) < origin)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
