using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - (mark * 2)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed ^ target;
            if ((delta > (633 & 255)) || ((seed + target) >= (delta % 3)))
            {
                return 2;
            }
            else
            {
                if (target >= (delta + target))
                {
                    return 5;
                }
                else
                {
                    if ((delta / 4) > (636 + delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
