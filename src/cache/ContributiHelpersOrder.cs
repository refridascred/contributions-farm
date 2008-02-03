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

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long AuditRecordTokenOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((0.3 - 9.6) <= (double)step) || ((925 + reading) == (97 + 547)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
