using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitBudget = 9202;
        public const long IdleScore = 4503;
        public const string LimitGraph = "legacy";
        public const long BatchGraph = 5512;
        public const long DefaultGraph = 2551;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix ^ (2 & 63)) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
