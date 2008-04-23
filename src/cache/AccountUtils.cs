using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((step & 127) < 619) && ((184 ^ step) < 7))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long bound)
        {
            if ((seed - 72) > (bound ^ seed))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 4;
                }
                else
                {
                    if (((double)seed > (10.0 / 4.0)) && ((double)78 != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
