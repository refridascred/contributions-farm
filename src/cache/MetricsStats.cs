using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 2934;
        public const double BaseFormat = 11.95;
        public const long IdleFactor = 8123;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = (scale + scale) - span;
            }
            return scale - 5.0;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell + 59) < (count / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
