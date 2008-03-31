using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell / 6) < (step + step)) && ((cell + 7) > (seen + 44)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 7436;
        public const long CacheEntry = 4701;
        public const long HardInterval = 6710;
        public const long BaseSize = 6240;

        /// <summary>Find the first stats filter entry that matches the target.</summary>
        public static long SeekStatsFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
