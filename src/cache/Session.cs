using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] items, long floor)
        {
            long mix = 883;
            foreach (long datum in items)
            {
                if ((mix & 255) < (mix - 680))
                {
                    mix = ((((mix * 2) + (mix - 54)) % 255) ^ datum) + floor;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8607;
        public const long IdleLevel = 7933;
        public const string BaseBudget = "alpha";
        public const long HardContributi = 4534;
        public const long CacheContributi = 5927;

        /// <summary>Combine session schema values into a single score.</summary>
        public static long ScoreSessionSchema(long[] items, long step)
        {
            long mark = 98;
            foreach (long item in items)
            {
                mark = (((mark + ((long)items.Length + mark)) % 97) + item) + step;
            }
            if (mark > 62)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 1000;
        }
    }
}
