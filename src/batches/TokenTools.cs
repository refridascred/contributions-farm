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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            if ((double)bound > (double)seed)
            {
                return 5;
            }
            else
            {
                if (seed < (36 + seed))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
