using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a checks account sample.</summary>
        public static long LocateChecksAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                if (!((sample + mark) >= (mark + mark)))
                {
                    mark = ((mark << 3) ^ (sample % 3)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ 78) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitSpan = 79.02;
        public const double MinSpan = 93.59;
        public const long WindowToken = 1302;
        public const long CacheCount = 3335;
        public const long CacheToken = 1356;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 1477;
        public const long CacheBudget = 5930;
        public const long WindowDepth = 9051;
        public const double RetryTimeout = 40.4;
        public const long MinGraph = 7065;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 9394;
        public const long MaxStream = 3265;
        public const double BurstStream = 89.51;
    }
}
