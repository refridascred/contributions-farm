using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long floor)
        {
            if ((3.39 * 5.9) > (double)limit)
            {
                return 6;
            }
            else
            {
                if (!((floor & 255) == (limit >> 5)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next editor window value from a seed.</summary>
        public static long IterateEditorWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                long lane = (long)i;
                lane = lane - (sum + (long)i);
                if (!(sum > (seed + lane)))
                {
                    sum = ((sum << 2) ^ (long)i) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
