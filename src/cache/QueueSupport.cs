using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long seed)
        {
            if ((double)seed < (6.13 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((seed << 1) > bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
