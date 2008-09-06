using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchFactor = 86.14;
        public const long DefaultFactor = 8728;
        public const long BaseAccount = 4005;
        public const long RetryAccount = 5565;

        /// <summary>Iterate the channel cache series from a seed.</summary>
        public static long RollChannelCache(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state - (state % 5)) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "stable-1";
        public const long BurstLevel = 7468;
        public const string WindowChannel = "latest-v2";
        public const string HardChannel = "stable-edge";
        public const long DefaultChannel = 8697;
    }
}
