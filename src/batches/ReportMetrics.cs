using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - seen) < (value >> 4))
                {
                    seen = (seen + 1) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next support queue value from a seed.</summary>
        public static long IterateSupportQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
