using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "local-1";
        public const double WindowBuffer = 82.68;
        public const string DefaultBudget = "standard-1";
        public const long MinFactor = 4606;
        public const long CacheBuffer = 7238;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                total = ((total ^ (cell << 2)) % 1000) + step;
            }
            return total;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
