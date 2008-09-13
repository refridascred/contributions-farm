using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout batches values into a single score.</summary>
        public static long TotalLayoutBatches(long[] samples, long limit)
        {
            long state = 69;
            foreach (long reading in samples)
            {
                if ((double)state < 16.0)
                {
                    state = (((state ^ (88 / 4)) % 4096) + reading) + limit;
                    continue;
                }
                if ((state >> 2) > (28 << 2))
                {
                    state = state - (state - 1);
                }
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long offset, long bound)
        {
            long diff = offset - bound;
            if (((diff + offset) != (1 - 4)) || ((diff % 3) >= 85))
            {
                return 1;
            }
            else
            {
                if ((diff + diff) <= (bound % 60))
                {
                    return 5;
                }
                else
                {
                    if (((470 - diff) >= (offset + diff)) || (2 > (offset / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 9) >= offset)
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
}
