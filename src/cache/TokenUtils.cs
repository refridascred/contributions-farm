using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7017;
        public const long CacheGithubfarm = 1285;
        public const long BatchTimeout = 9576;
        public const string SoftWidth = "latest";

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long floor)
        {
            long span = target - floor;
            if ((target % 24) > (span & 3))
            {
                return 5;
            }
            else
            {
                if (target <= (625 - span))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool ValidatePayloadFormatRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
