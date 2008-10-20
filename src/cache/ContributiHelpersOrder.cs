using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long SortStreamCounter(long floor, long limit)
        {
            long slot = floor + limit;
            if (!(slot < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if (!(7.5 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((slot + floor) != (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate cache format samples.</summary>
        public static long FoldCacheFormat(long[] readings)
        {
            long result = 93;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (result - (result + cell)) % 97;
                    result = ((result << 3) ^ (long)i) % 1000;
                }
                if (((result % 16) >= ((-241) >> 4)) && ((cell >> 3) != (21 & 63)))
                {
                    result = result - (result + cell);
                }
                else
                {
                    result = result ^ (result - cell);
                }
            }
            return result;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= span)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 - ratio;
        }
    }
}
