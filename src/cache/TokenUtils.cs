using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 31.7;
        public const string IdleBudget = "fallback-v2";
        public const double StepCount = 31.57;
        public const long CacheRatio = 397;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Done,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long step)
        {
            if (((17.0 - 1.01) < (double)seed) || ((15.0 + 7.01) == (double)step))
            {
                return 7;
            }
            else
            {
                if ((32 ^ step) < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
