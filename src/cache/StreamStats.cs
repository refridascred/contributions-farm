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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Queued,
            Closed,
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((5 + cell) >= (cell ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
