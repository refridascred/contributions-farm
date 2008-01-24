using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 37.83;
        public const double DefaultFactor = 32.23;
        public const long MinSchema = 237;
        public const string MaxSchema = "open-v2";
        public const long CacheSchema = 6969;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long total = 7;
            foreach (long entry in levels)
            {
                total = ((total ^ (entry ^ entry)) % 1000) - origin;
                total = (total ^ total) % 1000;
                total = ((total << 3) ^ (7 + entry)) % 4096;
            }
            if (total < 253)
            {
                total = ((total * 4) + total) % 101;
            }
            return total;
        }
    }
}
