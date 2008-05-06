using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long target)
        {
            if (!((1 + origin) < (origin + target)))
            {
                return 4;
            }
            else
            {
                if (27 > (target ^ target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state - 915) % 65521;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
