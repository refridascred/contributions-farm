using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) > (4 >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches << 2) == (matches - matches)) && ((entry >> 4) >= (entry - entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
