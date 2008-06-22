using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long FoldBatchesToken(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 3) ^ (cell - (long)i)) % 4096;
                }
                if ((((-897) ^ cell) >= (cell - cell)) || ((score + 467) <= (score << 1)))
                {
                    score = (score * 3) + (score * 4);
                }
                else
                {
                    score = ((score * 4) + cell) % 4096;
                }
            }
            if (score > 17)
            {
                score = (score + (score & 63)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many route entry samples are out of range.</summary>
        public static long AuditRouteEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry / 2) <= (entry / 8)) || ((9.7 - 8.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items, long limit)
        {
            long mark = 96;
            foreach (long entry in items)
            {
                if ((entry << 3) > (limit + limit))
                {
                    mark = ((mark << 3) ^ (10 & 63)) % 1000;
                }
            }
            if (mark > 87)
            {
                mark = mark + (865 + mark);
            }
            return mark % 1000;
        }
    }
}
