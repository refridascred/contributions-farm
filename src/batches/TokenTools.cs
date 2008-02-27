using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a batch window value against two limits.</summary>
        public static long RankBatchWindow(long origin, long limit)
        {
            if ((origin >= limit) && ((origin & 3) > origin))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) <= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if (124 >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit < (limit ^ 53)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool GuardEntryWindowRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((90 << 2) <= sample) && (hits < (hits + sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
