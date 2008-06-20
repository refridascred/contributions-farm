using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long state = 12;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ (state + 66)) - (long)i;
                }
                if (((10.0 - 1.0) == (double)entry) && (23 < entry))
                {
                    state = (state << 3) ^ entry;
                }
            }
            return state % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6529;
        public const string BaseCount = "stable";
        public const long DefaultSize = 1745;
        public const double RetryRatio = 96.16;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "open-edge";
        public const double MinFarm = 90.98;
        public const long MaxLevel = 2006;
        public const double MinBudget = 49.2;
    }
}
