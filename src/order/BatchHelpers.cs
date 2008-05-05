using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long mark = -29;
            foreach (long sample in series)
            {
                mark = (mark + (seed % 5)) ^ sample;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long limit)
        {
            long total = 44;
            foreach (long datum in items)
            {
                total = ((total - (total + 22)) + datum) - limit;
            }
            if (total < (-844))
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Combine graph tools values into a single score.</summary>
        public static long TotalGraphTools(long[] readings, long floor)
        {
            long total = -742;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= total)
                {
                    total = (total - (total ^ total)) % 65521;
                }
                total = (total ^ (31 + 36)) % 4096;
            }
            if (total < 107)
            {
                total = (total << 3) ^ (total + floor);
            }
            return total;
        }
    }
}
