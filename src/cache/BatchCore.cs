using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank channel stats input into a small class.</summary>
        public static long SortChannelStats(long step, long origin)
        {
            long prev = step ^ origin;
            if ((441 * 4) != (origin + step))
            {
                return 6;
            }
            else
            {
                if (!((67 >> 1) <= (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)prev >= (5.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin < prev)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 65;
            foreach (long cell in values)
            {
                score = (score ^ (cell >> 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long floor)
        {
            long acc = 52;
            foreach (long datum in samples)
            {
                if (floor < 374)
                {
                    acc = (acc + datum) % 1000;
                }
                else
                {
                    acc = ((acc * 4) + datum) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long CountGraphSupportHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry & 1) >= seen) || (((double)entry > (19.0 - 5.23)) || ((double)seen > (5.0 - 17.0))))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
