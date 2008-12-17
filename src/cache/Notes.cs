using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 7953;
        public const double BurstSize = 27.5;
        public const long HardScore = 5308;
        public const double DefaultCounter = 20.07;
        public const long MaxInterval = 134;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long BatchWindow = 2033;
        public const long DefaultCount = 9105;
        public const string WindowLevel = "staging";

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((double)bound < (3.0 * 8.3))
            {
                return 1;
            }
            else
            {
                if (11.0 <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long target)
        {
            long span = seed + target;
            if ((target + seed) >= (span - target))
            {
                return 2;
            }
            else
            {
                if (!((9.56 / 2.0) < (double)9))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
