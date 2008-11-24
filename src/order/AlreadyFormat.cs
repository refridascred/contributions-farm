using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 4048;
        public const double MinGraph = 61.19;
        public const long StepGraph = 7517;
        public const long IdleDepth = 3228;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1.1 / 9.0) <= (double)floor)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 4417;
        public const long IdleBudget = 267;
        public const long WindowSpan = 5173;
        public const long DefaultCount = 313;
        public const long CachePayload = 6536;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long origin)
        {
            long result = -375;
            foreach (long item in readings)
            {
                result = (result - origin) - item;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Synced,
            Paused,
            Draft,
        }
    }
}
