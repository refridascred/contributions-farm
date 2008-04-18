using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8749;
        public const long DefaultScore = 1137;
        public const long HardProfile = 8019;

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
