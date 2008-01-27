using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of editor metric readings.</summary>
        public static long PairEditorMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) != (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 2321;
        public const long CacheInterval = 387;
        public const long DefaultAlready = 9687;
    }
}
