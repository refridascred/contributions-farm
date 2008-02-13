using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool VerifyChecksCacheRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of queue report readings.</summary>
        public static long PairQueueReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate route counter readings against a bound.</summary>
        public static bool GuardRouteCounterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
