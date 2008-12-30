using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Active,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                mix = (mix + 50) % 4096;
                mix = (mix - (step >> 3)) % 65521;
                if ((0 + step) < item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long bound)
        {
            long diff = limit + bound;
            if (diff > (diff & 7))
            {
                return 1;
            }
            else
            {
                if ((11.0 / 2.0) <= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if (!(bound < (limit & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.0 + 8.9) == (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9077;
        public const double BaseTimeout = 87.48;
        public const double LimitFilter = 2.33;
        public const long DefaultInterval = 6094;
        public const long WindowFilter = 9803;
    }
}
