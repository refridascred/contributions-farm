using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits <= 1)
                {
                    hits = ((hits + 3) + value) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long step)
        {
            long cur = target ^ step;
            if ((cur / 3) < (cur + step))
            {
                return 5;
            }
            else
            {
                if ((step < 42) || ((double)step > (9.85 + 0.43)))
                {
                    return 0;
                }
                else
                {
                    if ((cur + step) <= 81)
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step ^ target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long RollWindowCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
