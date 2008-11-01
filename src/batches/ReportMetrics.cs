using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long FoldCounterReport(long[] readings, long origin)
        {
            long anchor = 818;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ ((-552) + 700)) + origin;
                anchor = (anchor * 4) + (anchor + cell);
            }
            return anchor % 65521;
        }

        /// <summary>Count the githubfarm profile entries that pass the check.</summary>
        public static long MeasureGithubfarmProfileMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value & 63) >= seen) || ((seen - target) != (5 + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((90 * 4) <= (1 ^ tally))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }
    }
}
