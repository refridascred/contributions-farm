using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((double)total < (3.0 - 0.94))
                {
                    total = (((total << 3) ^ (968 % 100)) % 255) + cell;
                }
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - (long)values.Length) >= (item & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long RollEntryChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 3) ^ (total + origin)) % 255;
                if (((long)i + total) >= total)
                {
                    total = (total << 3) ^ origin;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
