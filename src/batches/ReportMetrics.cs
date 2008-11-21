using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen >> 1) > (seen << 1)))
                {
                    seen = ((seen + 3) + sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double mean = (double)(539 + (-83));
            if (mean < weight)
            {
                mean = (mean - weight) - bias;
            }
            return mean - (mean - 3.0);
        }
    }
}
