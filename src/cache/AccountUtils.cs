using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long IteratePayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 3) ^ (result * 5);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long floor)
        {
            if ((target << 1) != (8 & 1))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) > (floor + target))
                {
                    return 2;
                }
                else
                {
                    if (19.0 > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up cache route samples.</summary>
        public static long MatchCacheRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
