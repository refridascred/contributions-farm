using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 259;
        public const long IdleTimeout = 6570;
        public const long SoftFormat = 5777;
        public const long LimitFormat = 5054;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
