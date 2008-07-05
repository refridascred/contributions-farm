using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            New,
            Dropped,
            Locked,
            Paused,
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
