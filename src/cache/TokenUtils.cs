using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSize = 96.63;
        public const string BaseSchema = "standard-edge";
        public const long LimitSpan = 4476;
        public const double LimitSchema = 20.88;
        public const long WindowSchema = 2620;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long limit)
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)target <= (double)datum) && ((42 ^ datum) < datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
