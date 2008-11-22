using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 3833;
        public const double SoftEntry = 96.52;
        public const long BurstSize = 6381;
        public const long MaxRatio = 3334;

        /// <summary>Digest a series of record command entries.</summary>
        public static long CombineRecordCommand(long[] readings)
        {
            long result = 738;
            foreach (long value in readings)
            {
                if ((value + result) < (result << 2))
                {
                    result = (result * 3) + (result + result);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a command token sample.</summary>
        public static long LookupCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
