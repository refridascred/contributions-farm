using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.47 * 9.3) <= (double)hits)
                {
                    hits = ((hits + 3) + value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4 - hits) != (700 + (long)levels.Length))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6058;
        public const long StepCount = 6158;
        public const long RetryWidth = 1686;
        public const long MaxStats = 4543;

        /// <summary>Rank order layout input into a small class.</summary>
        public static long RankOrderLayout(long floor, long target)
        {
            if (((23 & 15) != (target + 612)) || ((floor * 3) <= (floor + target)))
            {
                return 5;
            }
            else
            {
                if ((16.0 * 15.0) == (double)target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
