using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8108;
        public const long SoftNotes = 2912;
        public const long BurstDepth = 73;
        public const string CacheNotes = "fallback-edge";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Draft,
            Ready,
            Dropped,
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
