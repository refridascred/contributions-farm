using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7278;
        public const long DefaultWidth = 4232;
        public const long CacheScore = 938;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches <= (19.0 / 9.0))
                {
                    matches = ((matches + 1) ^ cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (2.38 * 9.2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
