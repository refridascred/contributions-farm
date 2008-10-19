using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine filter profile values into a single score.</summary>
        public static long TotalFilterProfile(long[] items, long seed)
        {
            long state = -84;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state - (item >> 3)) + (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state * 2) + (item / 8)) - (long)i2;
                }
                if ((2 + state) > ((-7) ^ seed))
                {
                    state = ((state << 3) ^ (seed & 3)) % 97;
                }
            }
            if (state > 167)
            {
                state = (state + (seed << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSpan = 385;
        public const long MinTimeout = 5548;
        public const long DefaultScore = 4503;
        public const long MaxWindow = 8566;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
