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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] levels, long origin)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if ((item + 11) > score)
                {
                    score = score + (origin + origin);
                }
            }
            return score % 1000;
        }
    }
}
