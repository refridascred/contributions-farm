using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 2150;
        public const long BaseSupport = 4911;
        public const string BatchSpan = "primary-edge";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long floor)
        {
            long bound = seed - floor;
            if ((bound + 5) < bound)
            {
                return 7;
            }
            else
            {
                if ((seed - floor) < bound)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate route batches readings against a bound.</summary>
        public static bool GuardRouteBatchesBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
