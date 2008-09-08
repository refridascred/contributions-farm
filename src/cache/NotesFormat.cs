using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (double)579)
                {
                    tally = tally + 3;
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
