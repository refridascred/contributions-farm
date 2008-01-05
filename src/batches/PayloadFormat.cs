using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 756;
        public const long MaxNotes = 6550;
        public const long CacheCount = 7520;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry + seen) < (entry / 6)) || ((seen & 31) <= (entry + entry))) || !((entry + entry) != (entry + 741)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample >= (5.3 / 7.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
