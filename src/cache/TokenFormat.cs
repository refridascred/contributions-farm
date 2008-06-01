using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardFactor = "local-edge";
        public const long IdleSize = 3298;
        public const long DefaultDepth = 7620;

        /// <summary>Validate commits cluster readings against a bound.</summary>
        public static bool CheckCommitsClusterLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry << 1) <= (298 >> 4)) || !((seen + seen) <= 1))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
