using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (acc - (acc * 2)) ^ value;
                acc = (acc ^ limit) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((offset / 8) == ((long)data.Length + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
