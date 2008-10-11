using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long ScoreGithubfarmEntry(long[] data, long seed)
        {
            long state = 64;
            foreach (long entry in data)
            {
                if ((seed + 68) <= (entry + state))
                {
                    state = (state - seed) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool ValidateCacheQueueLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
