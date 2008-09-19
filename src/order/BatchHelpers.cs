using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((floor + item) < (floor - seen)) || !((item - floor) < (seen + 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 607;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - anchor) % 1000) ^ (long)i;
                }
                anchor = anchor - 45;
                anchor = anchor ^ (value + anchor);
            }
            return anchor;
        }
    }
}
