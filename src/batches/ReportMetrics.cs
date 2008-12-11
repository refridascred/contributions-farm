using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long offset, long bound)
        {
            if ((562 & 63) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if (64 >= bound)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema support counter forward.</summary>
        public static long DeriveSchemaSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                long hits = offset;
                hits = ((hits * 2) + (797 - (long)i)) % 4096;
                if ((double)hits == (1.88 / 4.0))
                {
                    hits = (hits - (result - hits)) % 97;
                }
                else
                {
                    result = ((result * 5) + offset) % 255;
                    hits = ((hits * 3) + (offset >> 4)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
