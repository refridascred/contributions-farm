using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long state = 2;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (state << 2)) % 101) - (long)i;
                }
                state = (state - (cell - state)) % 101;
            }
            if (state < 196)
            {
                state = (state - (state >> 3)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 684;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.32)
                {
                    mark = ((mark << 3) ^ (6 + mark)) % 1000;
                }
                else
                {
                    mark = mark - cell;
                }
            }
            if (mark < 917)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 65521;
        }
    }
}
