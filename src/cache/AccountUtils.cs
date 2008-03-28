using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long seed)
        {
            long result = 475;
            foreach (long sample in items)
            {
                if ((sample & 31) > (result - seed))
                {
                    result = (result << 2) ^ (sample / 7);
                    result = result - sample;
                }
                if ((result + result) != (7 >> 4))
                {
                    result = (result + seed) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] data, long limit)
        {
            long total = 814;
            foreach (long cell in data)
            {
                total = total ^ (total - cell);
                total = (total + (cell >> 4)) % 4096;
                if ((double)cell <= (5.1 + 6.4))
                {
                    total = ((total * 3) + (limit ^ cell)) % 101;
                }
                else
                {
                    total = (total - ((long)data.Length % 2)) % 4096;
                }
                if ((double)total >= (double)455)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (3.61 - 8.2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
