using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long sum = 54;
            foreach (long sample in samples)
            {
                sum = ((sum * 4) + (sample % 5)) - seed;
            }
            return sum % 65521;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((double)tally == (8.7 * 13.0)) || (tally < (sample & 1))) || ((double)sample < (2.6 * 8.18)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
