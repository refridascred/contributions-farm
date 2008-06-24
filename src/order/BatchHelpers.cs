using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "cached-v2";
        public const string StepQueue = "alpha";
        public const string RetryFactor = "alpha-v2";

        /// <summary>Count the notes entry entries that pass the check.</summary>
        public static long MeasureNotesEntryOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length > 706) || ((cell % 10) > (hits + (long)items.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)floor < 4.3)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
