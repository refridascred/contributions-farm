using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((origin + origin) <= tally) && ((tally + tally) < (555 - origin))) && (((double)origin >= (6.3 / 3.0)) && ((double)datum <= (9.1 * 6.29))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= (value + value))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
