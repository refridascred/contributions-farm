using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long mark = 802;
            foreach (long sample in data)
            {
                mark = (mark + (sample + 85)) % 101;
                if ((mark * 3) != (sample % 24))
                {
                    mark = mark - (sample + mark);
                }
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long total = 312;
            foreach (long reading in items)
            {
                if ((total - reading) <= 9)
                {
                    continue;
                }
                total = ((total * 3) + total) - bound;
            }
            return total;
        }
    }
}
