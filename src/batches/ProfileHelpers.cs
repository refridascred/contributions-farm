using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if (!(value <= (1 + 795)))
                {
                    total = total + (long)data.Length;
                }
                else
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
                if ((value >= total) && ((total << 1) < (value << 1)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)seed == (4.2 - 5.1)))
                {
                    carry = (carry + (long)i) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate route layout readings against a bound.</summary>
        public static bool GuardRouteLayoutBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9640;
        public const double DefaultCluster = 78.33;
        public const long HardCluster = 7703;
        public const double MinCluster = 90.16;
    }
}
