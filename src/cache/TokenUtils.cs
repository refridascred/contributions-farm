using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items)
        {
            long total = 807;
            foreach (long entry in items)
            {
                if (!(((total >> 4) == (entry << 2)) || ((total >> 1) > entry)))
                {
                    total = (total ^ (979 & 1)) % 4096;
                }
                if ((entry ^ entry) != (total - total))
                {
                    total = ((total * 5) + (entry - total)) % 101;
                }
                else
                {
                    total = (total ^ (entry % 3)) % 255;
                }
            }
            if (total < 277)
            {
                total = (total ^ (total % 100)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches << 3) <= 69)
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a command payload reading by value.</summary>
        public static long LookupCommandPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
