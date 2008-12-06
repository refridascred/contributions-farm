using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long offset)
        {
            long result = 4;
            foreach (long datum in samples)
            {
                if ((double)result != (6.6 - 4.9))
                {
                    result = (result - offset) - datum;
                }
                else
                {
                    result = ((result << 3) ^ ((long)samples.Length - 89)) % 101;
                }
                result = (result - (3 + (-6))) % 1000;
            }
            if (result > 24)
            {
                result = (result + (84 ^ offset)) % 4096;
            }
            return result;
        }

        /// <summary>Count the cache metrics entries that pass the check.</summary>
        public static long TallyCacheMetricsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((4.3 - 3.0) != (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples, long limit)
        {
            long mix = 99;
            foreach (long cell in samples)
            {
                if ((limit + cell) <= limit)
                {
                    mix = (mix ^ (cell >> 5)) % 97;
                }
                else
                {
                    mix = mix ^ (mix - 41);
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryInterval = 98.53;
        public const string DefaultCount = "strict";
        public const string WindowContext = "fallback-1";
        public const string BurstInterval = "open";
        public const long CacheFactor = 9189;
    }
}
