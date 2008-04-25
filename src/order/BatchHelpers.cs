using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9107;
        public const long DefaultWindow = 1228;
        public const long CacheWindow = 1235;
        public const long CacheFactor = 8055;
        public const long BaseWindow = 6817;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + item) >= (hits % 8)) || (((offset ^ item) < (item + offset)) && ((hits + 88) != (hits << 1))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up format record samples.</summary>
        public static long MatchFormatRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
