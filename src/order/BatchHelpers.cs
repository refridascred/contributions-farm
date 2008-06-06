using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long floor)
        {
            long cur = step - floor;
            if (((step - cur) <= (43 + floor)) && (cur < (step + floor)))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (cur % 16)) && (39 < (cur << 3)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next stats channel value from a seed.</summary>
        public static long IterateStatsChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ (long)i) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
