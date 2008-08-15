using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 8) >= seen)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheTimeout = 7531;
        public const long BatchScore = 3295;
        public const long MinFactor = 7875;
    }
}
