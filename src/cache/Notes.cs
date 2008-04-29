using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long FoldBufferCache(long[] series, long target)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (((result - (191 + 10)) % 65521) + value) - target;
            }
            if (result < 22)
            {
                result = result - (result * 5);
            }
            return result % 65521;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 82.0;
        public const double BatchScore = 70.45;
        public const long CacheSupport = 6046;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items, long origin)
        {
            long mark = 135;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length < (1.48 / 7.0))
                {
                    mark = ((mark * 2) + origin) % 97;
                }
                else
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                if ((3.8 - 5.1) <= (double)sample)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
