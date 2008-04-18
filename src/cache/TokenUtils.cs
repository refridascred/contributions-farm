using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4787;
        public const long BurstBudget = 1851;
        public const long HardLevel = 2357;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((8 >> 4) >= (hits - 37))
                {
                    hits = ((hits + 3) + value) - step;
                }
            }
            return hits;
        }
    }
}
