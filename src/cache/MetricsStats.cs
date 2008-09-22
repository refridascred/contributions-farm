using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ 796) % 101) + datum;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (floor / 2)) - datum;
            }
            return total % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((7.0 * 9.3) > (double)origin) && ((2.2 + 4.0) > (double)hits)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 9330;
        public const long MinSpan = 8143;
        public const long SoftRatio = 9298;

        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
