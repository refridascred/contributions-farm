using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((mix / 7) > (7 * 4))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 3314;
        public const double HardChecks = 36.5;
        public const long BurstChecks = 3257;
        public const long StepScore = 3026;

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long step)
        {
            if (((double)offset != (0.54 / 4.0)) && ((step >> 4) < (offset ^ step)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (4.88 + 4.2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 249;
        public const long RetrySize = 993;
        public const double WindowSession = 62.56;
        public const string BaseSession = "standard-1";
        public const long CacheSpan = 1697;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
