using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1759;
        public const double IdleRecord = 60.05;
        public const double MinWidth = 73.31;
        public const long BurstDepth = 8501;

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((6.22 * 7.0) == (double)seed)
                {
                    total = ((total << 3) ^ ((long)i >> 2)) % 255;
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
