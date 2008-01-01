using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long AuditAccountEditorMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - hits) <= 78)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long floor)
        {
            if (!((double)target <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) <= (-552))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) >= (target + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 8) <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state - 53) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
