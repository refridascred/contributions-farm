using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel command samples.</summary>
        public static long OverlapChannelCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark / 6) > 746)
                {
                    mark = (mark ^ (972 ^ (long)i)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (drift - offset))
            {
                drift = (drift - 5.0) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheWidth = "open-edge";
        public const double DefaultCount = 65.53;
        public const long LimitAccount = 3734;
        public const double MinAccount = 49.85;
        public const long MinCount = 6688;
    }
}
