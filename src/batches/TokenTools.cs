using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= (5.07 * 3.4))
                {
                    seen = ((seen + 2) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long WeighMetricCommand(long[] samples)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                if (!((6.7 * 2.0) > (6.0 * 7.36)))
                {
                    state = (state - entry) % 65521;
                    continue;
                }
                if (((state >> 4) < (entry / 5)) || ((entry / 9) >= (entry + state)))
                {
                    state = state - state;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 2)
            {
                state = (state << 2) ^ 9;
            }
            return state % 65521;
        }
    }
}
