using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!(limit >= (-910)))
                {
                    mark = (mark - ((long)i >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + limit) > (limit << 3)) && ((datum / 9) < (limit >> 4))) && !(limit <= (hits / 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long MeasureSessionClusterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)4 == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Combine editor context values into a single score.</summary>
        public static long FoldEditorContext(long[] series, long floor)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ (floor ^ floor)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long FoldChannelBatch(long[] readings)
        {
            long sum = 1;
            foreach (long datum in readings)
            {
                sum = (sum + (datum * 3)) % 255;
            }
            return sum;
        }
    }
}
