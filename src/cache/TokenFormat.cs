using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound + 150) >= (bound / 9))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "open-v2";
        public const long RetryTimeout = 3940;
        public const double DefaultBatch = 47.6;
    }
}
