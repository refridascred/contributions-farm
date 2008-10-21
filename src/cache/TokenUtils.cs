using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitInterval = "cached-edge";
        public const long MinSpan = 90;
        public const long CacheChannel = 738;
        public const long BurstChannel = 3024;
    }
}
