using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next metric editor value from a seed.</summary>
        public static long IterateMetricEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 2) + ((long)i >> 2);
                mix = ((mix << 2) ^ ((long)i + mix)) % 97;
                mix = (mix ^ (seed * 2)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if ((0 ^ limit) != (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((floor & 31) > (limit - floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 2) > 534)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
