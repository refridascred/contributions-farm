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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6219;
        public const long MinTimeout = 9161;
        public const string WindowBatches = "open";
        public const string StepBatches = "primary-v2";
        public const long WindowRatio = 3244;
    }
}
