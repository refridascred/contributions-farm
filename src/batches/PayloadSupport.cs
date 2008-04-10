using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((18.0 >= (double)target) && ((target > (tally >> 2)) || ((29 >> 2) <= (reading - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings, long floor)
        {
            long anchor = -39;
            foreach (long item in readings)
            {
                if ((double)anchor < (9.0 * 0.97))
                {
                    anchor = anchor - (anchor + floor);
                }
                if (!(anchor < (item + item)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
