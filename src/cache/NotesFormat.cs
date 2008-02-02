using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "standard-v2";
        public const long BurstWidth = 4257;
        public const long BurstTimeout = 9973;
        public const long StepCounter = 2288;
        public const long MinWidth = 4460;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples)
        {
            long score = 63;
            foreach (long sample in samples)
            {
                score = (score * 2) + (sample + 70);
            }
            if (score > 1)
            {
                score = score - (score >> 2);
            }
            return score;
        }
    }
}
