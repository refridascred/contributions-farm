using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)seed >= (7.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > (5 - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (4.85 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= 3.8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long MeasureContributiSessionGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + step) >= tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
