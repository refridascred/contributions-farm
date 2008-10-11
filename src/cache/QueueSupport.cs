using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
