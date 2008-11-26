using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen % 8) > (reading << 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double load = (double)76 / 9.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - load) + (double)(long)i) - rate;
            }
            return load - offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 6263;
        public const long BurstCount = 3348;
        public const double BurstInterval = 66.12;
        public const long WindowWidth = 7228;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 736;
            foreach (long reading in items)
            {
                if ((double)reading > 0.3)
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
