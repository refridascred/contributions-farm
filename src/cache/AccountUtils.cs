using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TotalStreamQueue(long[] levels, long floor)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                result = (result - floor) + cell;
            }
            if (result > 681)
            {
                result = result + (floor + result);
            }
            return result % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if (((seed - floor) < (floor + floor)) && ((double)floor != (double)seed))
            {
                return 2;
            }
            else
            {
                if (((seed + floor) >= (seed & 15)) || ((5.0 - 14.0) >= (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long CountReportFarmHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((seed << 3) < reading) || ((reading ^ hits) >= 118)) && (((seed >> 1) == (hits / 6)) && ((5 - hits) <= (reading + hits))))
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
    }
}
