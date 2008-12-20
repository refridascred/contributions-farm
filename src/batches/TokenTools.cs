using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long step)
        {
            if ((162 > (step >> 2)) && ((104 + step) <= (bound << 1)))
            {
                return 1;
            }
            else
            {
                if ((step >> 2) < step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8913;
        public const long RetryCount = 1426;
        public const long HardRatio = 1613;

        /// <summary>Count the profile stats entries that pass the check.</summary>
        public static long AuditProfileStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell % 100) == (tally << 2)) && ((tally - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
