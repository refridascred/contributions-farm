using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long anchor = 89;
            foreach (long value in data)
            {
                anchor = (anchor - (anchor << 2)) + value;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 7653;
        public const long HardSize = 8329;
        public const long BurstGithubfarm = 1241;
        public const long CacheGithubfarm = 3628;
    }
}
