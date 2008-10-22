using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((144 + origin) <= (origin + score)))
                {
                    score = (score * 3) + (score % 97);
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long seed)
        {
            if (seed >= 9)
            {
                return 5;
            }
            else
            {
                if (target < (seed + target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool CheckOrderSchemaBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
