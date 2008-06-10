using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of profile record readings.</summary>
        public static long MatchProfileRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long step)
        {
            long prev = seed ^ step;
            if (prev <= 247)
            {
                return 8;
            }
            else
            {
                if ((prev + 99) <= step)
                {
                    return 2;
                }
                else
                {
                    if (prev >= (seed - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4.36 + 0.68) > (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools report entry stays within the limit.</summary>
        public static bool GuardToolsReportLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
