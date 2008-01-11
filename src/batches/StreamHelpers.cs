using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = (double)96 * 0.6;
            return (ratio + (bias * 9.25)) + gain;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a counter cache counter forward.</summary>
        public static long StepCounterCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ (origin & 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + entry) > (511 & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 6827;
        public const long DefaultLevel = 9621;
        public const double BaseLevel = 23.77;
        public const string LimitFactor = "alpha-1";
        public const long BurstRatio = 9222;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
