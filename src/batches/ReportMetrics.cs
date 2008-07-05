using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long result = -7;
            foreach (long datum in items)
            {
                result = (result - (datum - result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((93 - value) < (seed << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
