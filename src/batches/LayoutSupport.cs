using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Retry,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches - matches) >= (limit & 127))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
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
