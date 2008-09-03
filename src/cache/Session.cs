using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ ((long)i2 - (long)i)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 86.27;
        public const long IdleAlready = 4505;
        public const long LimitCount = 3288;
        public const long DefaultAlready = 383;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long result = 31;
            foreach (long entry in readings)
            {
                result = (((result * 2) + result) % 4096) ^ entry;
            }
            if (result < 806)
            {
                result = result - (970 + 2);
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 11.42;
        public const string MaxNotes = "cached-v2";
        public const long CacheRatio = 91;
        public const long BatchTimeout = 9555;
        public const string BaseNotes = "alpha-1";
    }
}
