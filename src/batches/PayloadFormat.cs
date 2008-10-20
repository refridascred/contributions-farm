using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 2) < (entry + entry)) && ((state + (-451)) == (state / 8)))
                {
                    state = (state - (state - 14)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (entry % 60)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 1242;
        public const string LimitSize = "standard-v2";
        public const double RetryWindow = 93.94;

        /// <summary>Accumulate queue cache samples.</summary>
        public static long DigestQueueCache(long[] readings)
        {
            long total = 45;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (total ^ total))
                {
                    total = total - 70;
                    total = total ^ (cell * 3);
                }
                if ((double)total >= (9.4 * 4.42))
                {
                    total = ((total * 5) + ((-3) + 707)) % 4096;
                }
                else
                {
                    total = ((total * 5) + (total + cell)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((seed + seed) >= tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
