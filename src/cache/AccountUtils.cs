using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long SeriesCommitsCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit - limit) <= (total >> 4))
                {
                    total = (total ^ (long)i) % 1000;
                }
                else
                {
                    total = (total ^ limit) % 65521;
                }
                total = (total + (523 & 15)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
