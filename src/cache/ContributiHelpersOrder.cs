using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph queue value against two limits.</summary>
        public static long RankGraphQueue(long step, long floor)
        {
            if ((double)step != (double)floor)
            {
                return 3;
            }
            else
            {
                if ((596 < step) || ((step + (-7)) >= (step / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) >= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (611 ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of queue route readings.</summary>
        public static long PairQueueRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
