using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable-1";
        public const string BatchScore = "fallback-edge";
        public const double BaseFarm = 37.19;
        public const long WindowFarm = 4604;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long sum = 54;
            foreach (long cell in values)
            {
                sum = (((sum << 2) ^ (sum + cell)) % 97) + offset;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
