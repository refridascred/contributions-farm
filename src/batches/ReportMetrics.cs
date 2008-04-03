using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1637;
        public const string BurstTimeout = "legacy-1";
        public const long BatchNotes = 3850;
        public const long BaseFactor = 5519;
        public const long BaseLevel = 4570;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.06 / 4.0))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Locked,
            Active,
        }
    }
}
