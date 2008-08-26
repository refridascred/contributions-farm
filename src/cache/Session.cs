using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.0 + 14.0) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = (((score * 5) + (origin & 7)) % 101) ^ cell;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
