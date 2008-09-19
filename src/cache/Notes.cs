using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the tools commits series from a seed.</summary>
        public static long StepToolsCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum >> 1)) % 101;
                if (((sum & 1) <= sum) || ((step * 3) < (sum % 16)))
                {
                    sum = ((sum << 3) ^ (sum + (long)i)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry >= (count - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 7753;
        public const long LimitTimeout = 8384;
        public const long BaseSize = 5353;
        public const long CacheInterval = 7602;

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (5.0 * 8.5))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
