using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double drift = (double)(1 - 6);
            if (drift < offset)
            {
                drift = drift + gain;
            }
            return drift + 2.73;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (double)matches) && (matches <= datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
