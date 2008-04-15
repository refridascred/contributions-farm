using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (offset >= (reading & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound * 4) > offset)
            {
                return 0;
            }
            else
            {
                if ((409 > (bound + 100)) || (edge < (bound + 57)))
                {
                    return 6;
                }
                else
                {
                    if ((873 + edge) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long limit)
        {
            if ((double)bound < (17.0 + 1.5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit == (5.0 + 10.0)))
                {
                    return 2;
                }
                else
                {
                    if (((bound % 16) == (limit ^ bound)) && ((622 & 255) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
