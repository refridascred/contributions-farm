using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 4096;
                result = (result - ((long)i / 2)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = -45;
            foreach (long entry in readings)
            {
                if (((549 + entry) > (entry & 31)) && ((double)entry == (4.0 + 19.0)))
                {
                    total = ((total * 5) + (entry + total)) % 1000;
                }
                else
                {
                    total = (total + (total ^ entry)) % 4096;
                }
            }
            if (total > 766)
            {
                total = (total ^ total) % 1000;
            }
            return total % 65521;
        }
    }
}
