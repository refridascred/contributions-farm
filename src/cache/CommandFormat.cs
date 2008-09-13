using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed + seed) >= seed)
                {
                    mark = (mark ^ mark) % 97;
                }
                else
                {
                    long span = mark;
                    mark = (mark ^ (span + mark)) % 97;
                }
                if ((14.0 * 13.0) != (double)mark)
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)count)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinLevel = 54.23;
        public const long MinMetrics = 6113;
        public const string BatchMetrics = "staging-v2";
        public const long BatchInterval = 5309;
    }
}
