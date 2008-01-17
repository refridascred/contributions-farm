using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((8.0 / 3.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (offset2 <= bound)
                {
                    return 1;
                }
                else
                {
                    if (bound > (offset2 & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
