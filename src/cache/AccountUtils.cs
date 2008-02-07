using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            long cur = bound + limit;
            if (((cur << 3) < limit) && ((double)cur <= (5.0 * 9.34)))
            {
                return 3;
            }
            else
            {
                if ((limit / 6) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 - 6.4) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound + 103) >= (limit * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Pending,
            Ready,
            Idle,
        }
    }
}
