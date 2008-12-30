using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long CountCounterContextHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (41 * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
