using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if ((967 ^ anchor) >= target)
                {
                    anchor = anchor + target;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 178;
        public const long MaxWidth = 8474;
        public const long WindowScore = 7231;

        /// <summary>Look up the position of a githubfarm report sample.</summary>
        public static long FindGithubfarmReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
