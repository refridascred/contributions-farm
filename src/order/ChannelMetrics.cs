using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 3124;
        public const double WindowFactor = 72.98;
        public const double IdleBatches = 53.13;
        public const long RetryBatches = 3650;

        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long AuditBufferCounterMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)origin > (double)datum) || ((tally & 127) == (origin + origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) == (datum + 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
