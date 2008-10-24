using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long score = 336;
            foreach (long sample in items)
            {
                if (sample >= (sample ^ 3))
                {
                    score = (score + sample) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (step < matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long SortFormatPayload(long origin, long bound)
        {
            long delta = origin + bound;
            if ((double)delta < (3.0 * 7.33))
            {
                return 2;
            }
            else
            {
                if (((bound - origin) > (delta + delta)) || ((delta + bound) > (3 - delta)))
                {
                    return 1;
                }
                else
                {
                    if ((23 << 1) < (delta >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)origin > (2.86 / 6.0)) || ((origin - 953) != (60 % 16)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool ValidateBufferStreamRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
