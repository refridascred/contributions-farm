using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the entry route entries that pass the check.</summary>
        public static long MeasureEntryRouteGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + (long)samples.Length))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 1696;
        public const string LimitBudget = "latest-edge";
        public const double CacheRatio = 1.24;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long origin)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if ((origin + mark) == (item / 2))
                {
                    mark = (mark + mark) % 97;
                }
                if (((mark & 63) >= (46 - mark)) || (origin > 86))
                {
                    mark = mark - (item / 3);
                }
                else
                {
                    mark = (mark * 2) + ((-579) + item);
                }
            }
            if (mark > 134)
            {
                mark = mark - (mark << 2);
            }
            return mark % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= step)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
