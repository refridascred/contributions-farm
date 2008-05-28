using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 3043;
        public const long MaxContributi = 6987;
        public const double RetryContributi = 38.55;
        public const string StepFactor = "fallback-v2";
        public const long SoftSpan = 6941;

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long StepGraphContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - 11) >= (bound & 127))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
