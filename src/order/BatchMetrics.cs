using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitCount = 24.34;
        public const double WindowWidth = 35.67;
        public const long BatchTools = 4855;
        public const long StepTools = 8429;

        /// <summary>Rank token profile input into a small class.</summary>
        public static long GradeTokenProfile(long bound, long offset)
        {
            long delta = bound - offset;
            if (((double)delta == (4.2 - 2.5)) && ((double)bound != (3.9 / 3.0)))
            {
                return 8;
            }
            else
            {
                if ((bound + offset) < (offset + delta))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 2) < (delta / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((5 + limit) > (item ^ 8)) || ((73 >> 2) != (state - (long)levels.Length)))
                {
                    state = (state + (9 + limit)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long MeasureSessionAccountHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (double)entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values, long limit)
        {
            long sum = -20;
            foreach (long cell in values)
            {
                if ((sum * 2) < cell)
                {
                    sum = (sum - (cell - sum)) - limit;
                }
                sum = ((sum * 2) + (cell + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
