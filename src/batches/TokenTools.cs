using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "cached-edge";
        public const long DefaultChannel = 2470;
        public const long SoftChannel = 8916;
        public const long MinWidth = 6709;
    }
}
