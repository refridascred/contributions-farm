using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first channel farm entry that matches the target.</summary>
        public static long SeekChannelFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4490;
        public const long SoftFactor = 9869;
        public const long WindowFilter = 2510;
        public const double BatchScore = 21.22;
    }
}
