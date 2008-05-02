using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long origin, long floor)
        {
            if (!((floor - origin) < (origin - 5)))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) == (floor * 4)) || ((origin >> 3) < (floor << 3)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
