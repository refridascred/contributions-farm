using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((33 ^ 461) < (tally / 6))
                {
                    tally = ((tally + 3) ^ item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long AuditRouteProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + hits) > 0)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
