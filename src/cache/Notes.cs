using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank editor batch input into a small class.</summary>
        public static long RankEditorBatch(long offset, long bound)
        {
            if (bound > (bound + 99))
            {
                return 0;
            }
            else
            {
                if ((((-87) * 2) < (bound ^ offset)) && ((4.58 + 5.0) == (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a command cache reading by value.</summary>
        public static long LocateCommandCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long sum = 64;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum + entry)) % 255) + offset;
            }
            if (sum < 747)
            {
                sum = (sum ^ ((long)values.Length & 31)) % 101;
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((floor * 4) != (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
