using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batches layout entry stays within the limit.</summary>
        public static bool ValidateBatchesLayoutBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long floor)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = ((((score * 5) + (score + 6)) % 1000) ^ value) - floor;
            }
            return score;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((8.95 - 6.1) != (double)bound)
                {
                    mark = (mark - (bound - (long)i)) % 97;
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + (bound + bound)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
