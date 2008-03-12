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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items, long floor)
        {
            long anchor = 88;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell * 2)) % 1000;
                if (!((floor + (long)items.Length) > anchor))
                {
                    anchor = (anchor ^ (cell ^ floor)) % 255;
                }
            }
            return anchor;
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
