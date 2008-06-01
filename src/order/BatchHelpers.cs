using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up cluster layout samples.</summary>
        public static long OverlapClusterLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long SortContributiFilter(long seed, long target)
        {
            if ((target + seed) <= (seed % 16))
            {
                return 6;
            }
            else
            {
                if ((4 + seed) <= (target >> 1))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
