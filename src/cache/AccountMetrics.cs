using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = (((mix * 2) + 417) % 255) + item;
            }
            return mix;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Pending,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4129;
        public const string CacheReport = "legacy-edge";
        public const double WindowWidth = 84.85;
        public const double SoftSpan = 85.92;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seed / 6) <= (-4)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
