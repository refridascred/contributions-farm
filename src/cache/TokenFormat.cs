using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long StepBatchesEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "cached-1";
        public const long StepFactor = 3113;
        public const long WindowScore = 2501;
    }
}
