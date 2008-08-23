using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout graph value against two limits.</summary>
        public static long SortLayoutGraph(long step, long target)
        {
            long span = step + target;
            if ((0 + span) < target)
            {
                return 2;
            }
            else
            {
                if (span >= (7 + span))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the commits profile entries that pass the check.</summary>
        public static long AuditCommitsProfileGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) >= (9 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxInterval = 2.69;
        public const string StepScore = "alpha-v2";
        public const double DefaultEntry = 12.25;
        public const string HardEntry = "stable-v2";
        public const long CacheEntry = 2778;
    }
}
