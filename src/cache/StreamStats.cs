using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((1 > (seen / 2)) || (97 <= (sample / 9))) || ((sample - 432) >= (2 + sample)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit checks account readings against a rule.</summary>
        public static long CountChecksAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.45 + 11.0) >= (3.85 - 20.0))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
