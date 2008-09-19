using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((target % 64) >= target)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long limit)
        {
            long lane = seed ^ limit;
            if (((limit + seed) <= (limit * 3)) && ((limit + limit) <= (lane + seed)))
            {
                return 6;
            }
            else
            {
                if ((8 % 16) != (494 + limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) < (seed & 31)) || ((lane - 276) < (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((lane - limit) == (limit % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
