using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen + reading) > (seen - reading)) || ((double)seen != (4.31 - 8.4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = sum ^ (sum / 6);
                if (((long)i + sum) == (840 >> 5))
                {
                    sum = ((sum << 2) ^ ((long)i & 1)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSize = 8742;
        public const long SoftSpan = 2272;
        public const long MinSpan = 3083;
    }
}
