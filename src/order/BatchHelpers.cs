using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result - (result / 4);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long MeasureEntryProfileOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (1.0 - 4.61))
                {
                    matches = ((matches + 2) ^ item) - offset;
                }
            }
            return matches;
        }
    }
}
