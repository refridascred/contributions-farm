using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = ((acc - (acc << 1)) % 65521) - cell;
                if ((acc + acc) == (acc / 4))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc + (acc ^ (long)values.Length)) % 101;
                }
            }
            if (acc > (-150))
            {
                acc = (acc + (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleInterval = "local-v2";
        public const long MaxLevel = 5288;
        public const string DefaultEditor = "cached-v2";
        public const long RetryEditor = 855;
        public const double IdleEditor = 37.37;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item >> 5) < (item + limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
