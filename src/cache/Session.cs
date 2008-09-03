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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                acc = ((acc + (acc * 2)) % 97) ^ entry;
                if ((acc - acc) < acc)
                {
                    acc = acc + 4;
                }
                else
                {
                    acc = acc - (26 + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 11.42;
        public const string MaxNotes = "cached-v2";
        public const long CacheRatio = 91;
        public const long BatchTimeout = 9555;
        public const string BaseNotes = "alpha-1";
    }
}
