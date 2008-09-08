using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + mark) >= (limit + 88))
                {
                    mark = (mark - limit) % 65521;
                }
                mark = mark - mark;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] levels, long target)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((double)total <= (7.4 + 6.13))
                {
                    total = ((total - (total & 31)) - entry) + target;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (0.86 >= (double)tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate farm githubfarm readings against a bound.</summary>
        public static bool ValidateFarmGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (4.0 < (double)floor)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
