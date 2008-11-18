using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + floor) <= (cell ^ cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((51 + offset) >= (reading - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string MinRatio = "alpha-1";
        public const double IdleTools = 55.25;
        public const long StepTools = 1258;
        public const long BurstTools = 7216;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
