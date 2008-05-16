using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)293)
                {
                    mark = (mark + ((long)samples.Length - 284)) % 1000;
                }
                else
                {
                    mark = (mark ^ reading) % 65521;
                }
            }
            return mark;
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
