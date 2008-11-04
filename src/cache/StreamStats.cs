using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long offset)
        {
            long bound = step - offset;
            if ((step + offset) <= bound)
            {
                return 0;
            }
            else
            {
                if (((step + offset) > offset) || ((5.0 * 1.08) < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + bound) == (bound + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long SortBatchesFilter(long floor, long step)
        {
            if (!((step + step) <= step))
            {
                return 0;
            }
            else
            {
                if (floor >= (step ^ step))
                {
                    return 1;
                }
                else
                {
                    if ((step + floor) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
