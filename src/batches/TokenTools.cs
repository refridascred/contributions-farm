using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseWidth = 82.66;
        public const double BurstContributi = 16.43;
        public const double SoftContributi = 82.45;
        public const long BatchContributi = 5802;
        public const double MaxBudget = 65.52;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((19.0 * 3.44) <= (double)entry)
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
