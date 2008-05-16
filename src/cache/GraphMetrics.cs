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

        /// <summary>Audit layout format readings against a rule.</summary>
        public static long MeasureLayoutFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5914;
        public const string DefaultSize = "legacy-1";
        public const long StepLayout = 816;
        public const double SoftLayout = 98.81;
        public const long RetryInterval = 7349;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Done,
            Idle,
            New,
        }
    }
}
