using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((503 >> 1) > (reading / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 55.74;
        public const long SoftEntry = 8736;
        public const long IdleLevel = 7604;
        public const long BaseEntry = 3401;
        public const long LimitEntry = 4234;
    }
}
