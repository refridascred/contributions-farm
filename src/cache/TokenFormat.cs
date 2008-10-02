using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 413;
        public const long MinChannel = 9525;
        public const long IdleInterval = 3395;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
