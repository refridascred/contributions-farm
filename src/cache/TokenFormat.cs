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

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchScore = 28.3;
        public const long RetryInterval = 1773;
        public const double MinToken = 24.57;
        public const long DefaultToken = 9349;

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
