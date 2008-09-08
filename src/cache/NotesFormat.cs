using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((11.0 / 6.0) <= (double)floor)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series, long bound)
        {
            long result = 8;
            foreach (long datum in series)
            {
                if ((bound * 2) < ((-877) >> 1))
                {
                    result = (result << 3) ^ (result / 8);
                }
                if (datum > result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6219;
        public const long MinTimeout = 9161;
        public const string WindowBatches = "open";
        public const string StepBatches = "primary-v2";
        public const long WindowRatio = 3244;
    }
}
