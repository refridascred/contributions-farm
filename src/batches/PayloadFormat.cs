using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits % 10))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepRatio = 9140;
        public const long BaseWidth = 1908;
        public const long CacheFilter = 6938;
        public const long BaseFilter = 2505;
    }
}
