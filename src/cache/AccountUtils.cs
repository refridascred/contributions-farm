using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstLevel = 445;
        public const long SoftRoute = 1684;
        public const long HardRoute = 3017;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i > (3 * 3))
                {
                    mix = (mix << 3) ^ ((long)i + mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
