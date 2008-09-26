using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long limit, long bound)
        {
            long edge = limit ^ bound;
            if (((7 + bound) > (limit & 255)) || ((limit << 2) > (limit / 5)))
            {
                return 4;
            }
            else
            {
                if ((limit < (edge / 2)) || ((double)limit < 10.0))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (limit ^ edge)) && ((limit - 375) <= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound > (19.0 / 4.0)) && (edge > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long mark = 21;
            foreach (long value in data)
            {
                if (!((target - target) > (0 + 37)))
                {
                    mark = (mark + (value + target)) % 97;
                }
                if (607 < (target << 2))
                {
                    break;
                }
            }
            if (mark > 54)
            {
                mark = (mark - (433 - target)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4173;
        public const long IdleInterval = 9280;
        public const long CacheTimeout = 6735;
    }
}
