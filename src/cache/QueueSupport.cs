using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long RankCacheFarm(long limit, long origin)
        {
            if ((double)limit <= (9.0 - 5.5))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (7.6 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if (!(origin <= (42 / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Ready,
            New,
            Paused,
            Synced,
        }
    }
}
