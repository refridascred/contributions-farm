using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry + seen) != (seen << 1)))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)seed < (9.7 + 1.55)) && (value < (seed - seed))) && (hits > (hits ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
