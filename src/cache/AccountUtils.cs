using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 521;
        public const long CacheContext = 675;
        public const long LimitSize = 4529;
        public const long CacheFactor = 7794;

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                if ((double)mix > (17.0 + 1.5))
                {
                    mix = (mix - (item ^ item)) % 65521;
                }
                else
                {
                    mix = (mix + 8) % 4096;
                }
            }
            return mix;
        }
    }
}
