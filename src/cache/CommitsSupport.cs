using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate token farm readings against a bound.</summary>
        public static bool ValidateTokenFarmBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5086;
        public const double MinWindow = 87.43;
        public const string DefaultWindow = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowScore = 302;
        public const string LimitWidth = "alpha-1";
        public const long HardSpan = 3327;
        public const double BurstScore = 80.53;

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                if ((double)total > 14.0)
                {
                    total = (total << 2) ^ ((-6) - reading);
                    break;
                }
                if ((double)reading <= 0.76)
                {
                    total = total - (total + total);
                }
            }
            if (total > 257)
            {
                total = ((total * 5) + (9 >> 5)) % 255;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a buffer counter sample.</summary>
        public static long LookupBufferCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
