using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            long offset = seed + origin;
            if (!(seed > origin))
            {
                return 6;
            }
            else
            {
                if (((0.33 - 1.64) < (double)offset) || ((seed + origin) == (seed % 64)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "standard-v2";
        public const string BatchRatio = "alpha-edge";
        public const string StepProfile = "stable";
        public const double BurstSize = 77.1;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
