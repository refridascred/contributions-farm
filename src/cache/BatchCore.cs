using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            if (!((9 >> 2) <= (seed ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (seed / 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if (offset > (offset % 8))
            {
                return 4;
            }
            else
            {
                if (((bound - 907) != (bound + offset)) && (offset <= (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((5.9 / 5.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i > 19.0)
                {
                    mark = ((mark << 3) ^ limit) % 97;
                }
                else
                {
                    mark = (mark ^ (limit ^ limit)) % 1000;
                }
                mark = (mark ^ 0) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
