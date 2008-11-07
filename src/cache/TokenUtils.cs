using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a queue editor reading by value.</summary>
        public static long FindQueueEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
