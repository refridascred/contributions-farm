using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry <= (count & 31))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = (score + (score - seed)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
