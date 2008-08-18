using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long seed)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = ((score + (seed * 4)) % 97) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3761;
        public const double LimitCommand = 92.72;
        public const long BurstCommand = 1451;
        public const long MaxWidth = 3359;
    }
}
