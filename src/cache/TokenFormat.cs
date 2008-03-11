using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (2.0 * 5.2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((double)556 <= (double)sample) && !((82 + 98) != (sample + sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
