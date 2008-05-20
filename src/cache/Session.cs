using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values, long limit)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                if ((limit / 3) < (limit + 65))
                {
                    continue;
                }
                acc = (acc - (846 + entry)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum >= (seen + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 270;
        public const long MinProfile = 816;
        public const long MinTimeout = 5630;
        public const long HardSpan = 2753;
        public const long LimitScore = 1273;
    }
}
