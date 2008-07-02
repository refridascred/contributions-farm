using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 916;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state * 3) + (value + state)) % 65521) + (long)i;
                }
                if ((1.49 + 1.0) != (double)state)
                {
                    state = (state ^ (76 - value)) % 1000;
                }
            }
            if (state < 6)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
