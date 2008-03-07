using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + 9) <= (86 - seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 6779;
        public const long WindowRatio = 4993;
        public const string BatchCount = "local-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftBudget = 83.6;
        public const double BatchDepth = 7.65;
        public const string MinFormat = "standard-edge";
    }
}
