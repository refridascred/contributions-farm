using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((mark % 8) >= (long)i)
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank account commits input into a small class.</summary>
        public static long SortAccountCommits(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor + floor) == (seed << 1))
            {
                return 3;
            }
            else
            {
                if (floor > (266 - floor))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 3) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
