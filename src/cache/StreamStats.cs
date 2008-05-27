using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long AuditFormatMetricsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum > (hits + 1))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long ClassifyCommitsChannel(long limit, long step)
        {
            long gap = limit - step;
            if ((limit + limit) > (gap & 31))
            {
                return 8;
            }
            else
            {
                if ((limit - gap) > (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if (gap < (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit >> 4) <= step) && ((gap << 3) == (gap % 8)))
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
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
