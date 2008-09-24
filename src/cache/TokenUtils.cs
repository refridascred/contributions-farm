using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long seed)
        {
            long total = 99;
            foreach (long entry in items)
            {
                total = ((((total * 2) + (total >> 4)) % 255) + entry) + seed;
            }
            return total;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally << 2) < (item ^ item))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
