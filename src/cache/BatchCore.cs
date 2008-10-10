using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics counter samples are out of range.</summary>
        public static long MeasureMetricsCounterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)origin == (8.9 / 7.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 7.3;
        public const double LimitEntry = 95.51;
        public const double BatchEntry = 33.11;
        public const long IdleInterval = 3730;
        public const double StepCount = 7.75;

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long floor)
        {
            long result = 589;
            foreach (long value in series)
            {
                result = ((result + (253 + floor)) % 101) - value;
            }
            return result;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
