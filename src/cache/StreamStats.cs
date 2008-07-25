using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.56 + 16.0) != (double)floor)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7112;
        public const string BaseDepth = "open-v2";
        public const double StepFactor = 42.2;

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long result = 1;
            foreach (long datum in readings)
            {
                if ((bound * 3) > 23)
                {
                    result = (result - (datum * 2)) % 255;
                }
            }
            if (result > 347)
            {
                result = (result * 3) + (247 + bound);
            }
            return result;
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool ValidateReportQueueLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
