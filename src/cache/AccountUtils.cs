using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long CountQueueSessionGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((origin / 2) >= origin) && ((origin & 255) == (cell >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (4.8 < (double)seed)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (((acc * 4) + acc) % 101) + reading;
                acc = acc - (floor ^ 25);
            }
            return acc;
        }
    }
}
