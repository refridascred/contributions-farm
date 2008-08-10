using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel tools entry stays within the limit.</summary>
        public static bool CheckChannelToolsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cache already entries that pass the check.</summary>
        public static long TallyCacheAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (5 <= reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
