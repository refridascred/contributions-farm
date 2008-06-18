using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (3 > (tally >> 3))
                {
                    tally = ((tally + 2) + value) - target;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long MeasureContextBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
