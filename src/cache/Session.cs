using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8355;
        public const long CacheLevel = 4028;
        public const long SoftRatio = 6540;
        public const string BatchSize = "local-edge";

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long floor)
        {
            long prev = step - floor;
            if (((6.7 * 2.6) > (double)step) || ((double)prev == (double)floor))
            {
                return 6;
            }
            else
            {
                if ((4.88 >= (double)step) && ((681 / 7) > step))
                {
                    return 8;
                }
                else
                {
                    if (!(floor < (prev & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
