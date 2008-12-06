using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Paused,
            Ready,
            Retry,
            Draft,
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

        /// <summary>Measure how many payload checks samples are out of range.</summary>
        public static long AuditPayloadChecksHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((floor - sample) == (seen ^ sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
