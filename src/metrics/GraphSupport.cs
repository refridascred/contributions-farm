using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) <= (sample << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)bound >= (4.65 - 4.0))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long DeriveReportMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((state * 2) < ((long)i >> 5))
                {
                    state = (state * 5) + (seed + 278);
                    break;
                }
                else
                {
                    state = state ^ seed;
                }
                state = (state << 3) ^ (seed - 575);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
