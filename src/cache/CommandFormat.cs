using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of editor order readings.</summary>
        public static long FoldEditorOrder(long[] values)
        {
            long mix = -21;
            foreach (long value in values)
            {
                mix = (mix - (14 - value)) % 255;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 8804;
        public const double BurstTimeout = 98.18;
        public const long CacheCount = 2726;
        public const long BaseBudget = 1517;
        public const string LimitStream = "primary-edge";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
