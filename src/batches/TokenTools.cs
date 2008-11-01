using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long AuditLayoutWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item > (item - item)) && !((count & 7) <= (item % 64)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long origin)
        {
            long span = bound + origin;
            if ((origin - origin) >= (6 + bound))
            {
                return 1;
            }
            else
            {
                if (bound <= (span + bound))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 64) > (span - bound)) || (origin <= (bound % 10)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - origin) == (6 - span))
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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
