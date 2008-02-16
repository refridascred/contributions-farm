using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 85.56;
        public const long WindowCluster = 1295;
        public const long MaxCluster = 314;
        public const double BaseSize = 93.88;
        public const long RetryCluster = 4059;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!(((state ^ offset) == (state - (long)i)) && ((double)state != (double)offset)))
                {
                    state = state ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
