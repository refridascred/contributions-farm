using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "staging-edge";
        public const double WindowFilter = 0.35;
        public const long MaxCount = 2450;
        public const double RetryFilter = 94.21;

        /// <summary>Combine token stream values into a single score.</summary>
        public static long TallyTokenStream(long[] items)
        {
            long score = -7;
            foreach (long sample in items)
            {
                score = ((score ^ score) % 4096) + sample;
            }
            if (score > 51)
            {
                score = (score ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Failed,
        }
    }
}
