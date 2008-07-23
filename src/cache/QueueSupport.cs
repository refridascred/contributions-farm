using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples, long bound)
        {
            long total = -997;
            foreach (long entry in samples)
            {
                total = ((((total * 5) + (96 >> 5)) % 97) - entry) - bound;
            }
            return total % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitTimeout = 48.95;
        public const string CacheBatch = "staging-edge";
        public const long RetryBatch = 6259;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
