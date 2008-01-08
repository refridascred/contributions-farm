using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((5 ^ item) >= 273) && ((double)hits >= 9.86))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 9) >= 1)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if ((6.1 - 8.8) < (double)seed2)
            {
                return 2;
            }
            else
            {
                if ((seed2 % 97) != (9 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 >= (9.2 * 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - seed2) <= (47 + seed))
                        {
                            return 6;
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
}
