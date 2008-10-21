using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((16.0 + 6.36) < (double)entry) && !((double)entry >= (0.1 - 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((5.2 / 9.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((bound << 2) > (seed ^ 51))
                {
                    return 8;
                }
                else
                {
                    if (((5 % 60) >= gap) && ((8 ^ bound) == (gap * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
