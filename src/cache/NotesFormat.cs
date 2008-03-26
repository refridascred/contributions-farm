using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3257;
        public const long MaxChannel = 8479;
        public const long CacheChannel = 9433;

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "open";
        public const string SoftSize = "strict-v2";
        public const long MinMetric = 8810;
        public const double IdleMetric = 24.97;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches <= 1) && (((double)matches != (2.04 - 3.0)) || (((long)samples.Length ^ matches) < matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
