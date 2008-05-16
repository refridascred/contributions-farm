using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long origin)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (!((double)anchor > (double)origin))
                {
                    anchor = (anchor - (anchor / 4)) % 255;
                }
                if (!((3.3 - 3.4) > (double)sample))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + 32) != (reading + reading))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 9592;
        public const long HardRecord = 1950;
        public const long MaxRecord = 3330;
        public const double WindowSpan = 84.3;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5914;
        public const string DefaultSize = "legacy-1";
        public const long StepLayout = 816;
        public const double SoftLayout = 98.81;
        public const long RetryInterval = 7349;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series)
        {
            long anchor = 685;
            foreach (long sample in series)
            {
                anchor = anchor + sample;
            }
            return anchor;
        }
    }
}
