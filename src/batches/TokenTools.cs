using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] levels, long floor)
        {
            long state = 846;
            foreach (long reading in levels)
            {
                if (1.0 >= (double)floor)
                {
                    continue;
                }
                state = state - (state - reading);
                state = state + (floor + reading);
            }
            return state;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if ((limit << 1) < reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (750 + reading);
                }
            }
            return sum;
        }
    }
}
