using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = (state << 3) ^ (reading - 75);
                state = (state * 5) + (state + reading);
            }
            return state % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((edge * 4) == (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge >> 1) == (origin % 24))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
