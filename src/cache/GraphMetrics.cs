using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the commits format entries that pass the check.</summary>
        public static long AuditCommitsFormatMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((seed ^ count) >= (long)samples.Length)
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 78.24;
        public const double BaseCount = 38.38;
        public const long CacheChecks = 6775;
        public const long StepBudget = 3134;
        public const long RetryChecks = 1863;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum + datum) <= (datum + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long bound)
        {
            long anchor = 26;
            foreach (long datum in values)
            {
                anchor = ((anchor << 3) ^ (bound ^ datum)) % 97;
            }
            if (anchor > 97)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
