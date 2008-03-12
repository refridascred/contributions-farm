using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((step >> 3) >= (tally + 9))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((slot + slot) == (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((offset % 5) < (offset + limit))
                {
                    return 2;
                }
                else
                {
                    if ((786 / 2) <= (slot + 946))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)950)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
