using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstTimeout = 6498;
        public const long WindowSpan = 4538;
        public const long StepSchema = 5794;
        public const double BatchSchema = 15.78;
        public const long RetrySchema = 151;

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value >= 433) || ((tally & 1) <= (tally & 255))) && ((value + tally) > (value - (-8))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
