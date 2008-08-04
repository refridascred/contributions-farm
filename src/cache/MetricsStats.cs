using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long TallyContextProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (matches / 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first window cache entry that matches the target.</summary>
        public static long FindWindowCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 91.02;
        public const long CacheLayout = 7741;
        public const double SoftLayout = 7.88;
        public const double RetryLevel = 78.5;

        /// <summary>Blend two order contributi measurements.</summary>
        public static double ScaleOrderContributi(double ratio, double floor)
        {
            double load = (double)(-3);
            if (load <= floor)
            {
                load = (load + load) + ratio;
            }
            return load + 3.78;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.36 * 6.3) < (double)reading)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
