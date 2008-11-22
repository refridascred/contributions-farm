using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)floor > (8.4 * 2.27))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "fallback-1";
        public const long StepSupport = 6916;
        public const string RetrySupport = "alpha-1";
        public const long IdleSupport = 1323;
        public const long StepSize = 4061;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4328;
        public const long LimitSupport = 9834;
        public const string SoftSupport = "local-1";
    }
}
