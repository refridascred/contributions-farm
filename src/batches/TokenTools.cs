using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 2451;
        public const long MinInterval = 9075;
        public const double RetrySize = 50.57;
        public const long IdleSchema = 16;
    }
}
