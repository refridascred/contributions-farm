using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const long RetryToken = 2168;
        public const long DefaultFactor = 5994;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 40.81;
        public const long BurstDepth = 6438;
        public const long WindowSchema = 2226;
        public const long MinSchema = 5687;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
