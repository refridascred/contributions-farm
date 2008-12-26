using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1.4 - 13.0) > (4.0 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long total = 386;
            foreach (long sample in series)
            {
                total = (total - (sample & 127)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySize = 1906;
        public const long DefaultTimeout = 749;
        public const long HardTimeout = 9331;
        public const double SoftBudget = 53.29;
        public const long StepTools = 2927;
    }
}
