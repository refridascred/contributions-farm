using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long floor)
        {
            if (!((target + target) <= (target % 8)))
            {
                return 0;
            }
            else
            {
                if (2.67 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value > (7.73 + 14.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
