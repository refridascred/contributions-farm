using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate route report samples.</summary>
        public static long TallyRouteReport(long[] data, long step)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((value * 3) < step)
                {
                    result = (result ^ ((-61) * 2)) % 65521;
                }
            }
            if (result < 39)
            {
                result = (result ^ (step ^ result)) % 101;
            }
            return result;
        }
    }
}
