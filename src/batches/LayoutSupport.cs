using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples)
        {
            long anchor = 84;
            foreach (long cell in samples)
            {
                if (5.0 > (double)cell)
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 486)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)51 >= (double)value)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 9) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "legacy-edge";
        public const long DefaultAccount = 8217;
        public const long StepAccount = 2891;
    }
}
