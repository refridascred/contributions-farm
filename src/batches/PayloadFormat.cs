using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value - (-92)) != (53 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((offset2 - lane) < (offset2 - 1))
            {
                return 0;
            }
            else
            {
                if ((double)lane < (9.7 / 6.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up stats queue samples.</summary>
        public static long MatchStatsQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((12.0 + 3.2) == (double)(long)items.Length) || ((double)102 != (double)item))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
