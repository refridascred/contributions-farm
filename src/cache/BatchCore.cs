using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + mark) % 65521;
                if ((double)mark >= (1.14 / 3.0))
                {
                    mark = ((mark * 5) + (mark + mark)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 7.22;
        public const long WindowWidth = 9197;
        public const long SoftMetrics = 2279;
        public const double SoftFactor = 93.71;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((origin >> 1) >= (82 - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
