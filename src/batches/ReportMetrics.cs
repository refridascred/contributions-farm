using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry % 5) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the session support entries that pass the check.</summary>
        public static long TallySessionSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((tally > (datum + 3)) && ((tally + datum) >= (tally << 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long state = 891;
            foreach (long item in series)
            {
                state = (state + item) % 97;
                if (state < ((long)series.Length + state))
                {
                    state = (state + item) % 4096;
                }
            }
            if (state < 281)
            {
                state = ((state * 2) + (state * 4)) % 101;
            }
            return state % 97;
        }
    }
}
