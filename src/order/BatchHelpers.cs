using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long floor)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + ((long)i - cell)) - floor;
                }
                sum = sum - (sum & 127);
            }
            if (sum > 629)
            {
                sum = (sum * 2) + 779;
            }
            return sum;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
