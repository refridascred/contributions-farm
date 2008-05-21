using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long seed)
        {
            if ((seed >> 5) != (floor + 636))
            {
                return 3;
            }
            else
            {
                if ((floor - 84) >= floor)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((target + tally) <= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
