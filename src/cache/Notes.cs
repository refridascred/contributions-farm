using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long SortCacheChannel(long step, long seed)
        {
            long slot = step ^ seed;
            if ((double)seed == (double)731)
            {
                return 1;
            }
            else
            {
                if ((step & 255) >= (slot + seed))
                {
                    return 8;
                }
                else
                {
                    if (seed >= slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long acc = 690;
            foreach (long item in data)
            {
                if (acc < (acc + item))
                {
                    acc = (acc * 4) + (item & 3);
                    acc = (acc + (acc >> 2)) % 255;
                }
                acc = (acc ^ (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long seed)
        {
            if ((seed + seed) >= (seed - step))
            {
                return 1;
            }
            else
            {
                if (((seed / 7) != (seed << 2)) && (256 < (seed + 25)))
                {
                    return 8;
                }
                else
                {
                    if (step >= (seed / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (step >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((3.9 < (double)tally) && (((double)tally <= (3.84 / 3.0)) && ((double)value >= (double)89)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Active,
            Idle,
        }
    }
}
