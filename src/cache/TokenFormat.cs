using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardFactor = 41.7;
        public const string WindowBuffer = "strict-edge";
        public const long SoftRatio = 5643;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + cell) >= cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
