using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long offset)
        {
            long score = 0;
            foreach (long reading in series)
            {
                if (offset >= reading)
                {
                    score = (score + (reading + 364)) % 4096;
                }
                score = score + (34 + score);
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample - matches) != (sample + 299))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
