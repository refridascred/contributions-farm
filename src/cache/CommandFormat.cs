using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3156;
        public const double CacheMetrics = 34.2;
        public const long StepScore = 4846;
        public const long DefaultMetrics = 7830;
        public const long BaseCount = 54;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit >> 3) < sample)
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 24;
        public const double HardInterval = 17.86;
        public const long WindowQueue = 2304;
        public const long BatchInterval = 9283;
        public const long DefaultTimeout = 6041;
    }
}
