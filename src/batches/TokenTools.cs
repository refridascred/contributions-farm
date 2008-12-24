using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)anchor >= (0.6 + 1.73)))
                {
                    anchor = anchor ^ (anchor << 3);
                }
                anchor = (anchor ^ (anchor + anchor)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (long)i) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4421;
        public const string HardSize = "strict";
        public const double WindowTimeout = 7.02;
        public const long LimitSize = 6034;
    }
}
