using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((2.2 / 5.0) <= (double)tally) && (((tally - tally) >= (93 / 6)) && (((long)levels.Length << 1) < tally)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const string SoftFactor = "fallback-v2";
        public const string BatchLevel = "alpha-edge";
        public const string HardToken = "cached-v2";
        public const long DefaultSize = 1163;

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultLevel = 0.99;
        public const long HardCommand = 4386;
        public const string CacheCommand = "latest";
        public const long SoftDepth = 459;
        public const long StepCommand = 2047;
    }
}
