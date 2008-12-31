using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (9 >= (hits - sample))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Combine channel order values into a single score.</summary>
        public static long FoldChannelOrder(long[] readings, long step)
        {
            long mark = 18;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (cell + mark)) % 255;
                if ((double)step < 4.0)
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 97.9;
        public const double SoftFactor = 84.14;
        public const long WindowRecord = 4242;
    }
}
