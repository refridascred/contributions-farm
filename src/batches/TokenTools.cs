using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryLevel = 71.78;
        public const long BurstTimeout = 8692;
        public const long BurstRatio = 3459;
        public const long MinProfile = 1163;
        public const string WindowProfile = "alpha-v2";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long target)
        {
            long prev = step - target;
            if (prev <= (step + 63))
            {
                return 5;
            }
            else
            {
                if ((double)step > (double)prev)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
