using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if (((2 >> 3) > target) && (66 <= (result - result)))
                {
                    continue;
                }
                if ((248 << 1) <= target)
                {
                    result = (result ^ ((long)i - (long)i)) % 101;
                    result = ((result << 3) ^ ((long)i * 2)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (result - (long)i)) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
