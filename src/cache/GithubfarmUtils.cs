using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if ((seed + offset) == (174 + offset))
            {
                return 4;
            }
            else
            {
                if (((offset * 3) <= seed) && ((double)offset < (7.32 + 18.0)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1166;
        public const long BatchFormat = 8534;
        public const long SoftDepth = 3969;

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long result = 774;
            foreach (long sample in series)
            {
                if ((result << 2) >= result)
                {
                    result = ((result * 3) + (sample << 1)) % 101;
                }
                else
                {
                    result = (result + (result + result)) % 1000;
                }
            }
            return result;
        }
    }
}
