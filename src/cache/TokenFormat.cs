using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ (long)levels.Length) <= (cell + origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxLevel = 47.13;
        public const double BatchInterval = 66.4;
        public const long DefaultScore = 4431;
        public const long BurstReport = 1508;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
