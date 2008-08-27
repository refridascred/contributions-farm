using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i > bound))
                {
                    state = ((state * 3) + bound) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
