using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowLevel = "strict-v2";
        public const long RetryEntry = 6486;
        public const long BaseEntry = 3110;
        public const long HardBudget = 7050;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) <= (9 + hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
