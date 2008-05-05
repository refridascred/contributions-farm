using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 8.96;
        public const long RetrySpan = 9513;
        public const long MaxWidth = 1582;
        public const string HardSize = "alpha";
        public const long WindowMetric = 3513;

        /// <summary>Audit token filter readings against a rule.</summary>
        public static long CountTokenFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((7.66 - 11.0) >= (double)seen) || ((reading + seen) < (seen - reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (double)target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
