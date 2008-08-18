using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long origin, long seed)
        {
            long step = origin - seed;
            if ((7.34 + 2.9) > (5.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((20 + 17) < (seed + 1)) && ((double)step == (9.93 * 3.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format already entries.</summary>
        public static long WeighFormatAlready(long[] data)
        {
            long mix = 251;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ mix) + item;
                if (mix <= (903 & 1))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long acc = 493;
            foreach (long datum in items)
            {
                acc = (((acc * 4) + (662 * 2)) % 101) ^ datum;
            }
            if (acc < 8)
            {
                acc = (acc ^ (acc % 60)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (long)i)
                {
                    total = (total - (total + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
