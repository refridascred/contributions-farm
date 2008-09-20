using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((double)floor2 == (double)2)
            {
                return 3;
            }
            else
            {
                if ((span > (floor >> 3)) && ((4 << 1) < (span + floor2)))
                {
                    return 6;
                }
                else
                {
                    if (!(span > (span % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor2 <= (floor ^ floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (7 >= (item % 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
