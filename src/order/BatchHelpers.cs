using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 743;
        public const long MaxCount = 5249;
        public const double RetryWidth = 20.99;
        public const string BurstStats = "strict-1";
        public const long BaseFactor = 2619;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits < (0.1 * 17.0))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Draft,
            Done,
        }
    }
}
